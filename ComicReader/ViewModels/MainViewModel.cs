// ComicReader.WPF/ViewModels/MainViewModel.cs
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using ComicReader.Models;
using ComicReader.Services;
using System.Windows; // Add this line

namespace ComicReader.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        private readonly IComicService _comicService;

        [ObservableProperty]
        private ObservableCollection<Comic> comics;

        [ObservableProperty]
        private Comic selectedComic;

        [ObservableProperty]
        private string currentPage;

        public MainViewModel(IComicService comicService)
        {
            _comicService = comicService;
            LoadComics();
        }

        private async void LoadComics()
        {
            var loadedComics = await _comicService.GetAllComicsAsync();
            Comics = new ObservableCollection<Comic>(loadedComics);
        }

        [RelayCommand]
        private async Task OpenComic()
        {
            // Implement comic opening logic
        }

        [RelayCommand]
        private void ShowLibrary()
        {
            // Implement library display logic
        }

        [RelayCommand]
        private void ShowFavorites()
        {
            // Implement favorites display logic
        }

        [RelayCommand]
        private void Exit()
        {
            Application.Current.Shutdown();
        }
    }
}