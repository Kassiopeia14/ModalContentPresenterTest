using modInterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ModalContentPresenterWPF.ViewModels
{
    public class SecondVM : ViewModelBase
    {
        private RelayCommand closeCommand;

        public ICommand CloseCommand
        {
            get
            {
                return closeCommand;
            }
        }

        MainVM MainVM;

        public SecondVM(MainVM mainVM)
        {
            closeCommand = new RelayCommand(Close);

            MainVM = mainVM;
        }

        public void Close(object sender)
        {
            MainVM.IsModal = false;
        }

    }
}
