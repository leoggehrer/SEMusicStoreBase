//@CodeCopy

#if IDINT_ON
global using IdType = System.Int32;
#elif IDLONG_ON
global using IdType = System.Int64;
#elif IDGUID_ON
global using IdType = System.Guid;
#else
global using IdType = System.Int32;
#endif

global using Common = SEMusicStoreBase.Common;
global using CommonContracts = SEMusicStoreBase.Common.Contracts;
global using CommonModels = SEMusicStoreBase.Common.Models;
global using CommonModules = SEMusicStoreBase.Common.Modules;
global using SEMusicStoreBase.Common.Extensions;

