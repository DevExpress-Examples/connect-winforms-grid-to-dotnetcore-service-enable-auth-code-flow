Imports System.Linq.Dynamic.Core
Imports System.Reflection
Imports System.Text.Json.Nodes
Imports System.Xml.Serialization
Imports Microsoft.AspNetCore.Authentication.JwtBearer
Imports Microsoft.AspNetCore.Authorization
Imports Microsoft.EntityFrameworkCore
' Note that this endpoint is NOT configured to require authorization. For the demo,
' this makes it possible to populate the database with test data without having to
' authenticate first. In a real-world application, you would want to secure this endpoint.
' The following two endpoints are read-only, so they only require an authenticated user.
' The following endpoints are read-write, so they require an authenticated user and
' compliance with the "writers" policy.
Imports Microsoft.IdentityModel.Tokens ' TODO: Error SkippedTokensTrivia '.'
' Development only!!
' TODO: Error SkippedTokensTrivia ')'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia '}'
' TODO: Error SkippedTokensTrivia ')'
' TODO: Error SkippedTokensTrivia ')'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia ';'
' Make sure the database exists and is current
' TODO: Error SkippedTokensTrivia 'using'
' TODO: Error SkippedTokensTrivia ')'
' TODO: Error SkippedTokensTrivia '{'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia '}'
' TODO: Error SkippedTokensTrivia ')'
' TODO: Error SkippedTokensTrivia ')'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia 'using'
' TODO: Error SkippedTokensTrivia 'Stream'
' TODO: Error SkippedTokensTrivia 'if'
' TODO: Error SkippedTokensTrivia 'null'
' TODO: Error SkippedTokensTrivia ')'
' TODO: Error SkippedTokensTrivia '{'
' TODO: Error SkippedTokensTrivia 'if'
' TODO: Error SkippedTokensTrivia 'null'
' TODO: Error SkippedTokensTrivia ')'
' TODO: Error SkippedTokensTrivia '{'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia 'return'
' TODO: Error SkippedTokensTrivia 'return'
' TODO: Error SkippedTokensTrivia '}'
' TODO: Error SkippedTokensTrivia ')'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia '}'
' TODO: Error SkippedTokensTrivia ')'
' TODO: Error SkippedTokensTrivia '.'
' TODO: Error SkippedTokensTrivia 'if'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia '}'
' TODO: Error SkippedTokensTrivia 'return'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia '}'
' TODO: Error SkippedTokensTrivia ')'
' TODO: Error SkippedTokensTrivia '.'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia 'return'
' TODO: Error SkippedTokensTrivia ')'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia '}'
' TODO: Error SkippedTokensTrivia ')'
' TODO: Error SkippedTokensTrivia '.'
' TODO: Error SkippedTokensTrivia ')'
' TODO: Error SkippedTokensTrivia '{'
' TODO: Error SkippedTokensTrivia 'return'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia 'return'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia '}'
' TODO: Error SkippedTokensTrivia ')'
' TODO: Error SkippedTokensTrivia '.'
' TODO: Error SkippedTokensTrivia 'if'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia '}'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia 'return'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia '}'
' TODO: Error SkippedTokensTrivia ')'
' TODO: Error SkippedTokensTrivia '.'
' TODO: Error SkippedTokensTrivia ';'
Imports System.Runtime.CompilerServices

 ''' Cannot convert FieldDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 852
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 451
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
''' 
''' var builder = WebApplication.CreateBuilder(args);
''' 
'''   ''' Cannot convert FieldDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 852
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 451
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
''' 
''' var publicKey = await GetKeycloakPublicKey(
'''     builder.Configuration["Jwt:KeycloakUrl"]!,
'''     builder.Configuration["Jwt:Realm"]!
''' );
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'builder\r\n .Services.AddAu...' at character 512
''' 
''' 
''' Input:
''' 
''' builder
'''     .Services.AddAuthentication
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(JwtBearerDefaults.Authenti...' at character 552
''' 
''' 
''' Input:
''' (JwtBearerDefaults.AuthenticationScheme)
'''     .
'''   ''' Cannot convert ConstructorDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 852
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitConstructorDeclaration(ConstructorDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 464
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
''' AddJwtBearer(options =>
'''     {
'''         options.RequireHttpsMetadata = false; // Development only!!
''' 
'''         options.TokenValidationParameters = new TokenValidationParameters
'''         {
'''             ValidateIssuer = true,
'''             ValidIssuer =
'''                 $"{builder.Configuration["Jwt:KeycloakUrl"]}/realms/{builder.Configuration["Jwt:Realm"]}",
'''             ValidateAudience = true,
'''             ValidAudience = builder.Configuration["Jwt:Audience"],
'''             ValidateLifetime = true,
'''             ValidateIssuerSigningKey = true,
'''             IssuerSigningKey = publicKey,
'''         };
'''     });
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'builder.Services.AddAuthori...' at character 1213
''' 
''' 
''' Input:
''' builder.Services.AddAuthorization
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(o ' at character 1246
''' 
''' 
''' Input:
''' (o =>
''' {
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'o.AddPolicy' at character 1260
''' 
''' 
''' Input:
'''     o.AddPolicy
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(' at character 1271
''' 
''' 
''' Input:
''' ("writers", 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'p' at character 1283
''' 
''' 
''' Input:
''' p => 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'p.RequireRealmRole' at character 1288
''' 
''' 
''' Input:
''' p.RequireRealmRole
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(' at character 1306
''' 
''' 
''' Input:
''' ("writers"));
''' });
''' 
'''   ''' Cannot convert FieldDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 852
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 451
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
''' 
''' string? connectionString = builder.Configuration.GetConnectionString("SqlExpressConnectionString");
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'builder.Services.AddDbConte...' at character 1431
''' 
''' 
''' Input:
''' 
''' builder.Services.AddDbContext<DataService.DataServiceDbContext>
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(o ' at character 1494
''' 
''' 
''' Input:
''' (o =>
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'o.UseSqlServer' at character 1505
''' 
''' 
''' Input:
'''     o.UseSqlServer
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(\r\n  connectionString,\r\...' at character 1519
''' 
''' 
''' Input:
''' (
'''         connectionString,
'''         options =>
'''         {
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'options.EnableRetryOnFailure' at character 1592
''' 
''' 
''' Input:
'''             options.EnableRetryOnFailure
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 1620
''' 
''' 
''' Input:
''' ();
'''         }
'''     )
''' );
''' 
'''   ''' Cannot convert FieldDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 852
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 451
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
''' 
''' var app = builder.Build();
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.UseAuthentication' at character 1677
''' 
''' 
''' Input:
''' app.UseAuthentication
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 1698
''' 
''' 
''' Input:
''' ();
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.UseAuthorization' at character 1703
''' 
''' 
''' Input:
''' app.UseAuthorization
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 1723
''' 
''' 
''' Input:
''' ();
''' 
''' // Make sure the database exists and is current
''' using 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(var scope ' at character 1785
''' 
''' 
''' Input:
''' (var scope = 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.Services.CreateScope' at character 1798
''' 
''' 
''' Input:
''' app.Services.CreateScope
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 1822
''' 
''' 
''' Input:
''' ())
''' {
''' 
'''   ''' Cannot convert FieldDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 852
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 451
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
'''     var dbContext = scope.ServiceProvider.GetRequiredService<DataService.DataServiceDbContext>();
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'dbContext.Database.Migrate' at character 1933
''' 
''' 
''' Input:
'''     dbContext.Database.Migrate
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 1959
''' 
''' 
''' Input:
''' ();
''' }
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.MapGet' at character 2235
''' 
''' 
''' Input:
''' 
''' // Note that this endpoint is NOT configured to require authorization. For the demo,
''' // this makes it possible to populate the database with test data without having to
''' // authenticate first. In a real-world application, you would want to secure this endpoint.
''' 
''' app.MapGet
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(\r\n' at character 2245
''' 
''' 
''' Input:
''' (
'''     "/api/populateTestData",
''' 
'''   ''' Cannot convert ConstructorDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 852
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitConstructorDeclaration(ConstructorDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 464
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
'''     async (DataService.DataServiceDbContext dbContext) =>
'''     {
''' 
'''   ''' Cannot convert FieldDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 852
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 451
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
'''         var assembly = Assembly.GetExecutingAssembly();
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'Console.WriteLine' at character 2409
''' 
''' 
''' Input:
'''         Console.WriteLine
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(String.Join' at character 2426
''' 
''' 
''' Input:
''' (String.Join
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(' at character 2438
''' 
''' 
''' Input:
''' ("\n", 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'assembly.GetManifestResourc...' at character 2445
''' 
''' 
''' Input:
''' assembly.GetManifestResourceNames
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 2478
''' 
''' 
''' Input:
''' ()));
''' 
'''   ''' Cannot convert FieldDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 852
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 451
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
'''         var resourceName = assembly
'''             .GetManifestResourceNames()
'''             .Single(str => str.EndsWith("order_items.xml"));
''' 
'''   ''' Cannot convert FieldDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 852
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 451
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
''' 
'''         var serializer = new XmlSerializer(typeof(List<DataService.OrderItem>));
''' 
'''         using Stream
'''   ''' Cannot convert FieldDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 852
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 451
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
''' ? stream = assembly.GetManifestResourceStream(resourceName);
'''         if 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(stream ' at character 2804
''' 
''' 
''' Input:
''' (stream is 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'not' at character 2815
''' 
''' 
''' Input:
''' not null)
'''         {
''' 
'''   ''' Cannot convert FieldDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 852
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 451
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
'''             var itemsField = (List<DataService.OrderItem>?)serializer.Deserialize(stream);
''' 
'''             if 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(items ' at character 2946
''' 
''' 
''' Input:
''' (items is 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'not' at character 2956
''' 
''' 
''' Input:
''' not null)
'''             {
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'dbContext.OrderItems.AddRange' at character 2998
''' 
''' 
''' Input:
'''                 dbContext.OrderItems.AddRange
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(items)' at character 3027
''' 
''' 
''' Input:
''' (items);
''' 
'''   ''' Cannot convert MethodDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 852
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 556
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
'''                 await dbContext.SaveChangesAsync();
'''                 return 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'Results.Ok' at character 3113
''' 
''' 
''' Input:
''' Results.Ok
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(' at character 3123
''' 
''' 
''' Input:
''' ("Data populated successfully");
'''             }
'''         }
''' 
'''         return 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'Results.NotFound' at character 3200
''' 
''' 
''' Input:
''' Results.NotFound
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(' at character 3216
''' 
''' 
''' Input:
''' ("Error populating data");
'''     }
''' );
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.MapGet' at character 3350
''' 
''' 
''' Input:
''' 
''' // The following two endpoints are read-only, so they only require an authenticated user.
''' 
''' app.MapGet
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(\r\n' at character 3360
''' 
''' 
''' Input:
''' (
'''         "/data/OrderItems",
''' 
'''   ''' Cannot convert ConstructorDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 852
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitConstructorDeclaration(ConstructorDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 464
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
'''         async (
'''             DataService.DataServiceDbContext dbContext,
'''             int skip = 0,
'''             int take = 20,
'''             string sortField = "Id",
'''             bool sortAscending = true
'''         ) =>
'''         {
''' 
'''   ''' Cannot convert FieldDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 852
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 451
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
'''             var source = dbContext
'''                 .OrderItems.AsQueryable()
'''                 .OrderBy(sortField + (sortAscending ? " ascending" : " descending"));
''' 
'''   ''' Cannot convert FieldDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 852
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 451
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
'''             var items = await source.Skip(skip).Take(take).ToListAsync();
''' 
'''   ''' Cannot convert FieldDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 852
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 451
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
''' 
'''             var totalCount = await dbContext.OrderItems.CountAsync();
''' 
'''             return 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'Results.Ok' at character 3958
''' 
''' 
''' Input:
''' Results.Ok
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(' at character 3968
''' 
''' 
''' Input:
''' (
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'new' at character 3969
''' 
''' 
''' Input:
''' new { 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'Items' at character 3975
''' 
''' 
''' Input:
''' Items = 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'items' at character 3983
''' 
''' 
''' Input:
''' items, 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'TotalCount' at character 3990
''' 
''' 
''' Input:
''' TotalCount = 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'totalCount' at character 4003
''' 
''' 
''' Input:
''' totalCount });
'''         }
'''     )
'''     .
'''   ''' Cannot convert ConstructorDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 852
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitConstructorDeclaration(ConstructorDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 464
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
''' RequireAuthorization();
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.MapGet' at character 4069
''' 
''' 
''' Input:
''' 
''' app.MapGet
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(\r\n' at character 4079
''' 
''' 
''' Input:
''' (
'''         "/data/OrderItem/{id}",
''' 
'''   ''' Cannot convert ConstructorDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 852
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitConstructorDeclaration(ConstructorDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 464
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
'''         async (DataService.DataServiceDbContext dbContext, int id) =>
'''         {
''' 
'''   ''' Cannot convert FieldDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 852
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 451
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
'''             var orderItemField = await dbContext.OrderItems.FindAsync(id);
''' 
'''             if 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(orderItem ' at character 4290
''' 
''' 
''' Input:
''' (orderItem is null)
'''             {
'''                 return 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'Results.NotFound' at character 4349
''' 
''' 
''' Input:
''' Results.NotFound
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 4365
''' 
''' 
''' Input:
''' ();
'''             }
''' 
'''             return 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'Results.Ok' at character 4406
''' 
''' 
''' Input:
''' Results.Ok
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(orderItem)' at character 4416
''' 
''' 
''' Input:
''' (orderItem);
'''         }
'''     )
'''     .
'''   ''' Cannot convert ConstructorDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 852
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitConstructorDeclaration(ConstructorDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 464
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
''' RequireAuthorization();
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.MapPost' at character 4610
''' 
''' 
''' Input:
''' 
''' // The following endpoints are read-write, so they require an authenticated user and
''' // compliance with the "writers" policy.
''' 
''' app.MapPost
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(\r\n' at character 4621
''' 
''' 
''' Input:
''' (
'''         "/data/OrderItem",
''' 
'''   ''' Cannot convert ConstructorDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 852
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitConstructorDeclaration(ConstructorDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 464
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
'''         async (DataService.DataServiceDbContext dbContext, DataService.OrderItem orderItem) =>
'''         {
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'dbContext.OrderItems.Add' at character 4771
''' 
''' 
''' Input:
'''             dbContext.OrderItems.Add
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(orderItem)' at character 4795
''' 
''' 
''' Input:
''' (orderItem);
''' 
'''   ''' Cannot convert MethodDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 852
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 556
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
'''             await dbContext.SaveChangesAsync();
'''             return 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'Results.Created' at character 4877
''' 
''' 
''' Input:
''' Results.Created
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(' at character 4892
''' 
''' 
''' Input:
''' ($"/data/OrderItem/{orderItem.Id}", 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'orderItem' at character 4928
''' 
''' 
''' Input:
''' orderItem);
'''         }
'''     )
'''     .
'''   ''' Cannot convert ConstructorDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 852
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitConstructorDeclaration(ConstructorDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 464
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
''' RequireAuthorization("writers");
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.MapPut' at character 5000
''' 
''' 
''' Input:
''' 
''' app.MapPut
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(\r\n' at character 5010
''' 
''' 
''' Input:
''' (
'''         "/data/OrderItem/{id}",
''' 
'''   ''' Cannot convert ConstructorDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 852
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitConstructorDeclaration(ConstructorDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 464
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
'''         async (DataService.DataServiceDbContext dbContext, int id, DataService.OrderItem orderItem) =>
'''         {
'''             if 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(id ' at character 5176
''' 
''' 
''' Input:
''' (id != 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'orderItem.Id' at character 5183
''' 
''' 
''' Input:
''' orderItem.Id)
'''             {
'''                 return 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'Results.BadRequest' at character 5236
''' 
''' 
''' Input:
''' Results.BadRequest
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(' at character 5254
''' 
''' 
''' Input:
''' ("Id mismatch");
'''             }
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'dbContext.Entry' at character 5301
''' 
''' 
''' Input:
''' 
'''             dbContext.Entry
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(orderItem)' at character 5316
''' 
''' 
''' Input:
''' (orderItem).
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'State' at character 5328
''' 
''' 
''' Input:
''' State = 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'EntityState.Modified' at character 5336
''' 
''' 
''' Input:
''' EntityState.Modified;
''' 
'''   ''' Cannot convert MethodDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 852
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 556
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
'''             await dbContext.SaveChangesAsync();
'''             return 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'Results.NoContent' at character 5427
''' 
''' 
''' Input:
''' Results.NoContent
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 5444
''' 
''' 
''' Input:
''' ();
'''         }
'''     )
'''     .
'''   ''' Cannot convert ConstructorDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 852
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitConstructorDeclaration(ConstructorDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 464
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
''' RequireAuthorization("writers");
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.MapDelete' at character 5508
''' 
''' 
''' Input:
''' 
''' app.MapDelete
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(\r\n' at character 5521
''' 
''' 
''' Input:
''' (
'''         "/data/OrderItem/{id}",
''' 
'''   ''' Cannot convert ConstructorDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 852
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitConstructorDeclaration(ConstructorDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 464
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
'''         async (DataService.DataServiceDbContext dbContext, int id) =>
'''         {
''' 
'''   ''' Cannot convert FieldDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 852
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 451
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
'''             var orderItem = await dbContext.OrderItems.FindAsync(id);
''' 
'''             if 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(orderItem ' at character 5727
''' 
''' 
''' Input:
''' (orderItem is null)
'''             {
'''                 return 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'Results.NotFound' at character 5786
''' 
''' 
''' Input:
''' Results.NotFound
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 5802
''' 
''' 
''' Input:
''' ();
'''             }
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'dbContext.OrderItems.Remove' at character 5836
''' 
''' 
''' Input:
''' 
'''             dbContext.OrderItems.Remove
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(orderItem)' at character 5863
''' 
''' 
''' Input:
''' (orderItem);
''' 
'''   ''' Cannot convert MethodDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 852
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 556
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
'''             await dbContext.SaveChangesAsync();
'''             return 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'Results.NoContent' at character 5945
''' 
''' 
''' Input:
''' Results.NoContent
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 5962
''' 
''' 
''' Input:
''' ();
'''         }
'''     )
'''     .
'''   ''' Cannot convert ConstructorDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 852
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitConstructorDeclaration(ConstructorDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 464
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
''' RequireAuthorization("writers");
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.Run' at character 6026
''' 
''' 
''' Input:
''' 
''' app.Run
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 6033
''' 
''' 
''' Input:
''' ();
''' 
'''   ''' Cannot convert MethodDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 852
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 556
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
''' 
''' static async Task<SecurityKey> GetKeycloakPublicKey(string keycloakUrl, string realm)
''' {
'''     using (var httpClient = new HttpClient())
'''     {
'''         var jwksUrl = $"{keycloakUrl}/realms/{realm}/protocol/openid-connect/certs";
'''         var jwksJson = await httpClient.GetStringAsync(jwksUrl);
'''         var jwks = new JsonWebKeySet(jwksJson);
'''         return jwks.Keys[0];
'''     }
''' }
''' 
'''  Public Module PolicyHelpers

    <Extension()>
    Public Sub RequireRealmRole(ByVal policy As AuthorizationPolicyBuilder, ByVal roleName As String)
        policy.RequireAssertion(Function(context)
            Dim realmAccess = context.User.FindFirst("realm_access")?.Value
            If realmAccess Is Nothing Then Return False
            Dim node = JsonNode.Parse(realmAccess)
            If node Is Nothing OrElse node("roles") Is Nothing Then Return False
             ''' Cannot convert LocalDeclarationStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax'.
'''    at ICSharpCode.CodeConverter.VB.CommonConversions.RemodelVariableDeclaration(VariableDeclarationSyntax declaration) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommonConversions.cs:line 478
'''    at ICSharpCode.CodeConverter.VB.MethodBodyExecutableStatementVisitor.VisitLocalDeclarationStatement(LocalDeclarationStatementSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\MethodBodyExecutableStatementVisitor.cs:line 59
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingMethodBodyVisitor.cs:line 24
''' 
''' Input:
'''             var array = node["roles"]!.AsArray();
''' 
'''  Return array.[Select](Function(r) r?.GetValue(Of String)()).Contains(roleName)
        End Function)
    End Sub
End Module
