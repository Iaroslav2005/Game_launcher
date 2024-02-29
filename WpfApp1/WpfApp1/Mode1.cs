using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp1
{
    internal class Mode1 : ModeBase
    {
        private Page WOW = new WOW();
        private Page Hs = new Hs();
        private Page OW = new OW();
        private Page W3 = new W3();
        private Page DIABLO = new DIABLO();
        private Page HOST = new HOST();
        private Page SC2 = new SC2();
        private Page SC = new SC();
        private Page _CurPage = new WOW();

        public Page CurPage
        {
           get=> _CurPage; 
           set => Set(ref _CurPage, value);
        }


        public ICommand OpenHsPage => new RelayCommand(() =>
        {
            if (CurPage != null && CurPage is Hs)
            {
                // Логика открытия страницы Hs
            }
        });

        public ICommand OpenWOWPage => new RelayCommand(() =>
        {
            if (CurPage != null && CurPage is WOW)
            {
                // Логика открытия страницы Hs
            }
        });

        public ICommand OpenOWPage => new RelayCommand(() =>
        {
            if (CurPage != null && CurPage is OW)
            {
                // Логика открытия страницы Hs
            }
        });

        public ICommand OpenW3Page => new RelayCommand(() =>
        {
            if (CurPage != null && CurPage is W3)
            {
                // Логика открытия страницы Hs
            }
        });

        public ICommand OpenDIABLIPage => new RelayCommand(() =>
        {
            if (CurPage != null && CurPage is DIABLO)
            {
                // Логика открытия страницы Hs
            }
        });

        public ICommand OpenHOSTPage => new RelayCommand(() =>
        {
            if (CurPage != null && CurPage is HOST)
            {
                // Логика открытия страницы Hs
            }
        });

        public ICommand OpenSC2Page => new RelayCommand(() =>
        {
            if (CurPage != null && CurPage is SC2)
            {
                // Логика открытия страницы Hs
            }
        });

        public ICommand OpenSCPage => new RelayCommand(() =>
        {
            if (CurPage != null && CurPage is SC)
            {
                // Логика открытия страницы Hs
            }
        });



    }


}
