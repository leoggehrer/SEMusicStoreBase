﻿//@CodeCopy
#if ACCOUNT_ON
namespace SEMusicStoreBase.WebApi.Contracts
{
    partial interface IContextAccessor
    {
        string SessionToken { set; }
    }
}
#endif
