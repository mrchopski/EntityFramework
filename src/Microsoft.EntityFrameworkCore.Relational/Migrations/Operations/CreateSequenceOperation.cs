// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.EntityFrameworkCore.Migrations.Operations
{
    public class CreateSequenceOperation : SequenceOperation
    {
        public virtual long StartValue { get; set; } = 1L;
    }
}
