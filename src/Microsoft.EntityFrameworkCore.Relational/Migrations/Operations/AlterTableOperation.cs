// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;

namespace Microsoft.EntityFrameworkCore.Migrations.Operations
{
    public class AlterTableOperation : TableOperation
    {
        public virtual TableOperation OldTable { get; [param: NotNull] set; }
    }
}
