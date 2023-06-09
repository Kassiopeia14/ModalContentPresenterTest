using Microsoft.Extensions.DependencyInjection;
using ModalContentPresenterWPF.ViewModels;
using System.Windows;

namespace ModalContentPresenterWPF
{
    public class ViewModelLocator
    {
        public MainVM MainViewModel
        {
            get
            {
                return (Application.Current as App).ProgramHost.Services.GetService<MainVM>();
            }
        }

        public FirstVM FirstViewModel
        {
            get
            {
                return (Application.Current as App).ProgramHost.Services.GetService<FirstVM>();
            }
        }

        public SecondVM SecondViewModel
        {
            get
            {
                return (Application.Current as App).ProgramHost.Services.GetService<SecondVM>();
            }
        }
    }
}
