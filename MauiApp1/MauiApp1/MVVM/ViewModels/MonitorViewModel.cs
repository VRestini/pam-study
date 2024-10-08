using CommunityToolkit.Mvvm.ComponentModel;
using MauiApp1.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiApp1.MVVM.ViewModel
{
    
    public partial class MonitorViewModel:ObservableObject
    {
        private readonly MonitorService monitorService;

        private ICommand getMonitoresCommand { get; }

        [ObservableProperty]
        private ObservableCollection<Models.Monitor> monitoresList = new();

        public async void getMonitores()
        {
            var monitores = await monitorService.getAllMonitorsAsync();
            foreach (var monitor in monitores)
            {
                monitoresList.Add(monitor);
            }
        }
        
        public MonitorViewModel()
        {
            getMonitoresCommand = new Command(getMonitores);
            getMonitoresCommand.Execute(this);
        }



    }
}
