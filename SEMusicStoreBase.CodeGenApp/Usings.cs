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
global using CommonModules = SEMusicStoreBase.Common.Modules;
global using SEMusicStoreBase.Common.Extensions;
global using CommonStaticLiterals = SEMusicStoreBase.Common.StaticLiterals;
global using TemplatePath = SEMusicStoreBase.Common.Modules.Template.TemplatePath;
