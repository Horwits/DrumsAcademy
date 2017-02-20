using System;

using WebFormsMvp;

namespace DrumsAcademy.WebForms.PresenterFactories
{
    public interface ICustomPresenterFactory
    {
        IPresenter GetPresenter(Type presenterType, IView viewInstance);
    }
}