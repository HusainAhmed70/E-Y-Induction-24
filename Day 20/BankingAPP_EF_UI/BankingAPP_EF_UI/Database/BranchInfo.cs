﻿using System;
using System.Collections.Generic;

namespace BankingAPP_EF_UI.Database;

public partial class BranchInfo
{
    public int BranchNo { get; set; }

    public string? BranchName { get; set; }

    public string? BranchLocation { get; set; }

    public virtual ICollection<AccountsInfo> AccountsInfos { get; set; } = new List<AccountsInfo>();
}
