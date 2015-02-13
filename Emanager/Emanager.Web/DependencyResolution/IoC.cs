using Emanager.Core;
using Emanager.Web.Infrastructure;
using StructureMap;
namespace Emanager.Web {
    public static class IoC {
        public static IContainer Initialize() {
            ObjectFactory.Initialize(x =>
                        {
                            x.Scan(scan =>
                                    {
                                        scan.TheCallingAssembly();
                                        scan.WithDefaultConventions();
                                    });
                            //when you see something that needs an Idepartment datasource. Then the concrete type I want you to put into
                            //that compooinent is departmentdb. 
                            //structure map hooks into the mvc runtime

                            
                         x.For<IDepartmentDataSource>().HttpContextScoped().Use<DepartmentDb>();
                        });
            return ObjectFactory.Container;
        }
    }
}