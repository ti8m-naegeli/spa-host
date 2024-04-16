using GenHTTP.Engine;
using GenHTTP.Modules.IO;
using GenHTTP.Modules.Practices;
using GenHTTP.Modules.SinglePageApplications;

var tree = ResourceTree.FromDirectory("/spa");

var spa = SinglePageApplication.From(tree);

return Host.Create()
           .Handler(spa)
           .Defaults()
           .Console()
#if DEBUG
           .Development()
#endif
           .Run();
