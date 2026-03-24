using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;
using UebungFarben.Core.Services;

namespace UebungFarbe.Core.ViewModels;

// partial er soll was schreiben und wir auch
public partial class MainViewModel : ObservableObject

{
    IFarbeTheme _theme;
    public MainViewModel(IFarbeTheme theme)
    {
        _theme = theme;
    }
    [ObservableProperty]
    private string _farbe = "";

    [RelayCommand]
    private void CLick()
    {
        this.Farbe = this._theme.Farbe;
    }

}

