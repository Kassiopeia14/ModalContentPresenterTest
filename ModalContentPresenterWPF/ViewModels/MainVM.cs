using ModalContentPresenterWPF.Models;
using modInterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ModalContentPresenterWPF.ViewModels
{
    public class MainVM : ViewModelBase
    {
        private BaseSomething somethingItem;
        public BaseSomething SomethingItem 
        { 
            get 
            { 
                return somethingItem; 
            } 
            set 
            { 
                somethingItem = value;
                RaisePropertyChanged(nameof(SomethingItem)); 
            } 
        }

        private bool isModal;
        public bool IsModal 
        {
            get 
            {
                return isModal;
            }
            set
            {
                isModal = value;                
                RaisePropertyChanged(nameof(IsModal));
            }
        }

        private RelayCommand? showFirstCommand;
        public ICommand? ShowFirstCommand
        {
            get
            {
                return showFirstCommand;
            }
        }

        private RelayCommand? showSecondCommand;
        public ICommand? ShowSecondCommand
        {
            get
            {
                return showSecondCommand;
            }
        }

        public MainVM() 
        {
            showFirstCommand = new RelayCommand(ShowFirst);
            showSecondCommand = new RelayCommand(ShowSecond);

            IsModal = false;
        }

        public void ShowFirst(object sender)
        {
            SomethingItem = new SomethingA();

            IsModal = true;
        }
        public void ShowSecond(object sender)
        {
            SomethingItem = new SomethingB();

            IsModal = true;
        }
    }
}
