using Autofac;
using Autofac.Extras.DynamicProxy;

using Business.Abstract;
using Business.Concrete;

using Castle.DynamicProxy;

using Core.Utilities.Interceptors;

using DataAccess.Abstract;
using DataAccess.Concrete;

namespace Business.DependencyResolvers.Autofac;

public class AutofacBusinessModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<CommentManager>().As<ICommentService>().SingleInstance();
        builder.RegisterType<EfCommentDal>().As<ICommentDal>().SingleInstance();

        builder.RegisterType<GenreManager>().As<IGenreService>().SingleInstance();
        builder.RegisterType<EfGenreDal>().As<IGenreDal>().SingleInstance();

        builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
        builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();

        builder.RegisterType<MovieManager>().As<IMovieService>().SingleInstance();
        builder.RegisterType<EfMovieDal>().As<IMovieDal>().SingleInstance();



        var assembly = System.Reflection.Assembly.GetExecutingAssembly();

        builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
            .EnableInterfaceInterceptors(new ProxyGenerationOptions()
            {
                Selector = new AspectInterceptorSelector()
            }).SingleInstance();
    }
}
