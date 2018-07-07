# Sulmar.WPFMVVM.201807
Przykłady ze szkolenia WPF MVVM + EF



## Biblioteki
Fody https://github.com/Fody/PropertyChanged


## Entity Framework - migracje
* Enable-Migrations
* Add-Migration 
* Update-Database [-verbose]

## Projekty

| Projekt  | Opis  |
|---|---|
| Model  | Model danych   |
| IServices | Interfejsy usług   |
| MockServices  | Implementacja "udawanych" usług   |
| DbServices  | Implementacja usług dostępu do bazy danych  |
| ViewModels  | ViewModels |
| Common  | Implementacja RelayCommand |
| WPFClient  | Klient WPF |

## Kroki

1. Utwórz klasę XXX w Models
2. Utwórz interfejs IXXXsServices w IServices
3. Utwórz implementację MockXXXsServices w MockServices
4. Utwórz implementację DbXXXsServices w DbServices
5. Utwórz ViewModel XXXsViewModel w ViewModels
6. Utwórz widok XXXsView.xaml WPFClient w Views
