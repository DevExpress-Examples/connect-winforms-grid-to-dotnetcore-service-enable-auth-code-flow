using System.Drawing.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;

namespace WinForms.Client
{
    public partial class MainForm : XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        class CustomOverlayTextPainter(string text) : OverlayWindowPainterBase
        {
            static readonly Font font = new("Tahoma", 16, FontStyle.Bold);

            protected override void Draw(OverlayWindowCustomDrawContext context)
            {
                var cache = context.DrawArgs.Cache;
                cache.TextRenderingHint = TextRenderingHint.AntiAlias;

                context.DrawBackground();

                var bounds = context.DrawArgs.Bounds;
                var midX = bounds.Left + bounds.Width / 2;
                var midY = bounds.Top + bounds.Height / 2;

                SizeF textSize = cache.CalcTextSize(text, font);
                cache.DrawString(
                    text,
                    font,
                    Brushes.Black,
                    new PointF(midX - textSize.Width / 2, midY + 30)
                );

                context.Handled = true;
            }
        }

        class CustomOverlayImagePainter : OverlayImagePainter
        {
            public CustomOverlayImagePainter(Image image, Action clickAction)
                : base(image, clickAction: clickAction) { }

            protected override Rectangle CalcImageBounds(
                OverlayLayeredWindowObjectInfoArgs drawArgs
            )
            {
                var midX = drawArgs.Bounds.Left + drawArgs.Bounds.Width / 2;
                var midY = drawArgs.Bounds.Top + drawArgs.Bounds.Height / 2;
                return new Rectangle(
                    new Point(midX - Image.Size.Width / 2, midY - Image.Size.Height / 2 - 50),
                    Image.Size
                );
            }
        }

        IOverlaySplashScreenHandle? overlayHandle;

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            ShowOverlay();

            DataServiceClient.LogInStatusChanged += LogInStatusChanged;
        }

        private void ShowOverlay()
        {
            overlayHandle = SplashScreenManager.ShowOverlayForm(
                this,
                opacity: 200,
                customPainter: new OverlayWindowCompositePainter(
                    new CustomOverlayTextPainter("Click the lock to log in"),
                    new CustomOverlayImagePainter(svgImageCollection.GetImage(0), LogIn)
                )
            );
        }

        private void LogIn()
        {
            if (!DataServiceClient.LoggedIn)
            {
                DataServiceClient.LogIn();
            }
        }

        private void LogInStatusChanged(object? sender, EventArgs e)
        {
            if (DataServiceClient.LoggedIn)
            {
                EvaluateRoles();
                logOutItem.Caption =
                    $"Log out {DataServiceClient.Name}{(userIsWriter ? " (Writer)" : "")}";
                if (overlayHandle is not null)
                    SplashScreenManager.CloseOverlayForm(overlayHandle);
                Invoke(
                    new Action(() =>
                    {
                        gridControl.DataSource = virtualServerModeSource;
                    })
                );
            }
        }

        private void logOutItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DataServiceClient.LoggedIn)
            {
                EvaluateRoles();
                gridControl.DataSource = null;
                logOutItem.Caption = "Log Out";
                DataServiceClient.LogOut();
                ShowOverlay();
            }
        }

        private bool userIsWriter = false;

        private void EvaluateRoles()
        {
            if (DataServiceClient.LoggedIn)
            {
                if (DataServiceClient.UserHasRole("writers"))
                {
                    userIsWriter = true;
                    addItemButton.Enabled = true;
                    deleteItemButton.Enabled = true;
                }
                else
                {
                    userIsWriter = false;
                    addItemButton.Enabled = false;
                    deleteItemButton.Enabled = false;
                }
            }
            else
            {
                userIsWriter = false;
                addItemButton.Enabled = false;
                deleteItemButton.Enabled = false;
            }
        }

        private VirtualServerModeDataLoader? loader;

        private void VirtualServerModeSource_ConfigurationChanged(
            object? sender,
            DevExpress.Data.VirtualServerModeRowsEventArgs e
        )
        {
            loader = new VirtualServerModeDataLoader(e.ConfigurationInfo);
            e.RowsTask = loader.GetRowsAsync(e);
        }

        private void VirtualServerModeSource_MoreRows(
            object? sender,
            DevExpress.Data.VirtualServerModeRowsEventArgs e
        )
        {
            if (loader is not null)
            {
                e.RowsTask = loader.GetRowsAsync(e);
            }
        }

        private void NotAWriterError()
        {
            XtraMessageBox.Show(
                "You are not authorized to edit items.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        private async void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (!userIsWriter)
            {
                NotAWriterError();
                return;
            }
            if (sender is GridView view)
            {
                if (view.FocusedRowObject is OrderItem oi)
                {
                    var editResult = EditForm.EditItem(oi);
                    if (editResult.changesSaved)
                    {
                        await DataServiceClient.UpdateOrderItemAsync(editResult.item);
                        view.RefreshData();
                    }
                }
            }
        }

        private async void addItemButton_ItemClick(
            object sender,
            DevExpress.XtraBars.ItemClickEventArgs e
        )
        {
            if (!userIsWriter)
            {
                NotAWriterError();
                return;
            }
            if (gridControl.FocusedView is ColumnView view)
            {
                var createResult = EditForm.CreateItem();
                if (createResult.changesSaved)
                {
                    await DataServiceClient.CreateOrderItemAsync(createResult.item!);
                    view.RefreshData();
                }
            }
        }

        private async void deleteItemButton_ItemClick(
            object sender,
            DevExpress.XtraBars.ItemClickEventArgs e
        )
        {
            if (!userIsWriter)
            {
                NotAWriterError();
                return;
            }
            if (
                gridControl.FocusedView is ColumnView view
                && view.GetFocusedRow() is OrderItem orderItem
            )
            {
                await DataServiceClient.DeleteOrderItemAsync(orderItem.Id);
                view.RefreshData();
            }
        }
    }
}
