/// <copyright file="IBlockModel.cs" manufacturer="CodeGears">
///   Copyright (c) CodeGears. All rights reserved.
/// </copyright>

using System.Collections.Generic;
using JetBrains.ReSharper.Psi;

namespace CodeGears.ReSharper.Exceptional.Model
{
    internal interface IBlockModel
    {
        List<IExceptionsOriginModel> ExceptionOriginModels { get; }
        List<TryStatementModel> TryStatementModels { get; }
        IBlockModel ParentBlock { get; }
        bool CatchesException(IDeclaredType exception);
        IDeclaredType GetCatchedException();
        IEnumerable<ThrownExceptionModel> ThrownExceptionModelsNotCatched { get; }
    }
}