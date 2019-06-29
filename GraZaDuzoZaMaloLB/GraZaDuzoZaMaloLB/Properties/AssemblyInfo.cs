using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;

// Ogólne informacje o zestawie s? kontrolowane poprzez nast?puj?cy 
// zestaw atrybutów. Zmie? warto?ci tych atrybutów, aby zmodyfikowa? informacje
// powi?zane z zestawem.
[assembly: AssemblyTitle("GraZaDuzoZaMaloLB")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("GraZaDuzoZaMaloLB")]
[assembly: AssemblyCopyright("Copyright ©  2019")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Ustawienie elementu ComVisible na warto?? false sprawia, ?e typy w tym zestawie s? niewidoczne
// dla sk?adników COM. Je?li potrzebny jest dost?p do typu w tym zestawie z
// COM, ustaw warto?? true dla atrybutu ComVisible tego typu.
[assembly: ComVisible(false)]

//Aby rozpocz?? kompilacj? aplikacji mo?liwych do zlokalizowania, ustaw
//<UICulture>Kultura_u?ywana_podczas_kodowania</UICulture> w pliku csproj
//w grupie <PropertyGroup>. Je?li na przyk?ad jest u?ywany j?zyk angielski (USA)
//w plikach ?ród?owych ustaw dla elementu <UICulture> warto?? en-US. Nast?pnie usu? komentarz dla
//poni?szego atrybutu NeutralResourceLanguage. Zaktualizuj warto?? „en-US” w
//poni?szej linii tak, aby dopasowa? ustawienie UICulture w pliku projektu.

//[assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)]


[assembly: ThemeInfo(
    ResourceDictionaryLocation.None, //gdzie znajduj? si? s?owniki zasobów specyficznych dla motywów
                                     //(u?ywane, je?li nie mo?na odnale?? zasobu na stronie,
                                     // lub s?owniki zasobów aplikacji)
    ResourceDictionaryLocation.SourceAssembly //gdzie znajduje si? s?ownik zasobów ogólnych
                                              //(u?ywane, je?li nie mo?na odnale?? zasobu na stronie,
                                              // aplikacji lub s?owników zasobów specyficznych dla motywów)
)]


// Informacje o wersji zestawu zawieraj? nast?puj?ce cztery warto?ci:
//
//      Wersja g?ówna
//      Wersja pomocnicza
//      Numer kompilacji
//      Poprawka
//
// Mo?esz okre?li? wszystkie warto?ci lub u?y? domy?lnych numerów kompilacji i poprawki
// przy u?yciu symbolu „*”, tak jak pokazano poni?ej:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
