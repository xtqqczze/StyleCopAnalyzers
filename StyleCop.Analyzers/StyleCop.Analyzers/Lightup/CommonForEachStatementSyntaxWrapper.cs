﻿// Copyright (c) Tunnel Vision Laboratories, LLC. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace StyleCop.Analyzers.Lightup
{
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp.Syntax;

    internal partial struct CommonForEachStatementSyntaxWrapper : ISyntaxWrapper<StatementSyntax>
    {
        internal const string FallbackWrappedTypeName = "Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax";

        static CommonForEachStatementSyntaxWrapper()
        {
            WrappedType = SyntaxWrapperHelper.GetWrappedType(typeof(CommonForEachStatementSyntaxWrapper));
            AwaitKeywordAccessor = LightupHelpers.CreateSyntaxPropertyAccessor<StatementSyntax, SyntaxToken>(WrappedType, nameof(AwaitKeyword));
            ForEachKeywordAccessor = LightupHelpers.CreateSyntaxPropertyAccessor<StatementSyntax, SyntaxToken>(WrappedType, nameof(ForEachKeyword));
            OpenParenTokenAccessor = LightupHelpers.CreateSyntaxPropertyAccessor<StatementSyntax, SyntaxToken>(WrappedType, nameof(OpenParenToken));
            InKeywordAccessor = LightupHelpers.CreateSyntaxPropertyAccessor<StatementSyntax, SyntaxToken>(WrappedType, nameof(InKeyword));
            ExpressionAccessor = LightupHelpers.CreateSyntaxPropertyAccessor<StatementSyntax, ExpressionSyntax>(WrappedType, nameof(Expression));
            CloseParenTokenAccessor = LightupHelpers.CreateSyntaxPropertyAccessor<StatementSyntax, SyntaxToken>(WrappedType, nameof(CloseParenToken));
            StatementAccessor = LightupHelpers.CreateSyntaxPropertyAccessor<StatementSyntax, StatementSyntax>(WrappedType, nameof(Statement));

            WithAwaitKeywordAccessor = LightupHelpers.CreateSyntaxWithPropertyAccessor<StatementSyntax, SyntaxToken>(WrappedType, nameof(AwaitKeyword));
            WithForEachKeywordAccessor = LightupHelpers.CreateSyntaxWithPropertyAccessor<StatementSyntax, SyntaxToken>(WrappedType, nameof(ForEachKeyword));
            WithOpenParenTokenAccessor = LightupHelpers.CreateSyntaxWithPropertyAccessor<StatementSyntax, SyntaxToken>(WrappedType, nameof(OpenParenToken));
            WithInKeywordAccessor = LightupHelpers.CreateSyntaxWithPropertyAccessor<StatementSyntax, SyntaxToken>(WrappedType, nameof(InKeyword));
            WithExpressionAccessor = LightupHelpers.CreateSyntaxWithPropertyAccessor<StatementSyntax, ExpressionSyntax>(WrappedType, nameof(Expression));
            WithCloseParenTokenAccessor = LightupHelpers.CreateSyntaxWithPropertyAccessor<StatementSyntax, SyntaxToken>(WrappedType, nameof(CloseParenToken));
            WithStatementAccessor = LightupHelpers.CreateSyntaxWithPropertyAccessor<StatementSyntax, StatementSyntax>(WrappedType, nameof(Statement));
        }

        public SyntaxToken AwaitKeyword
        {
            get
            {
                return AwaitKeywordAccessor(this.SyntaxNode);
            }
        }

        public SyntaxToken ForEachKeyword
        {
            get
            {
                return ForEachKeywordAccessor(this.SyntaxNode);
            }
        }

        public SyntaxToken OpenParenToken
        {
            get
            {
                return OpenParenTokenAccessor(this.SyntaxNode);
            }
        }

        public SyntaxToken InKeyword
        {
            get
            {
                return InKeywordAccessor(this.SyntaxNode);
            }
        }

        public ExpressionSyntax Expression
        {
            get
            {
                return ExpressionAccessor(this.SyntaxNode);
            }
        }

        public SyntaxToken CloseParenToken
        {
            get
            {
                return CloseParenTokenAccessor(this.SyntaxNode);
            }
        }

        public StatementSyntax Statement
        {
            get
            {
                return StatementAccessor(this.SyntaxNode);
            }
        }

        public static implicit operator CommonForEachStatementSyntaxWrapper(ForEachStatementSyntax node)
        {
            return new CommonForEachStatementSyntaxWrapper(node);
        }

        public CommonForEachStatementSyntaxWrapper WithAwaitKeyword(SyntaxToken awaitKeyword)
        {
            return new CommonForEachStatementSyntaxWrapper(WithAwaitKeywordAccessor(this.SyntaxNode, awaitKeyword));
        }

        public CommonForEachStatementSyntaxWrapper WithForEachKeyword(SyntaxToken forEachKeyword)
        {
            return new CommonForEachStatementSyntaxWrapper(WithForEachKeywordAccessor(this.SyntaxNode, forEachKeyword));
        }

        public CommonForEachStatementSyntaxWrapper WithOpenParenToken(SyntaxToken openParenToken)
        {
            return new CommonForEachStatementSyntaxWrapper(WithOpenParenTokenAccessor(this.SyntaxNode, openParenToken));
        }

        public CommonForEachStatementSyntaxWrapper WithInKeyword(SyntaxToken inKeyword)
        {
            return new CommonForEachStatementSyntaxWrapper(WithInKeywordAccessor(this.SyntaxNode, inKeyword));
        }

        public CommonForEachStatementSyntaxWrapper WithExpression(ExpressionSyntax expression)
        {
            return new CommonForEachStatementSyntaxWrapper(WithExpressionAccessor(this.SyntaxNode, expression));
        }

        public CommonForEachStatementSyntaxWrapper WithCloseParenToken(SyntaxToken closeParenToken)
        {
            return new CommonForEachStatementSyntaxWrapper(WithCloseParenTokenAccessor(this.SyntaxNode, closeParenToken));
        }

        public CommonForEachStatementSyntaxWrapper WithStatement(StatementSyntax statement)
        {
            return new CommonForEachStatementSyntaxWrapper(WithStatementAccessor(this.SyntaxNode, statement));
        }
    }
}
