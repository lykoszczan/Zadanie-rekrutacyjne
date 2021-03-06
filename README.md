# Zadanie-rekrutacyjne

## Spis treści
* [Opis](#opis)
* [Cel powstania aplikacji](#cel-powstania-aplikacji)
* [Założenia projektowe](#założenia-projektowe)
* [Działanie aplikacji](#działanie-aplikacji)
* [Modyfikacje](#modyfikacje)
* [Kontakt](#kontakt)

## Opis
Aplikacja służy do otwierania/zapisywania obrazów z/do plików tekstowych o określonym formacie. Powstała ona w lutym 2018 roku. Kod programu został napisany w języku C# i wykorzystuje on środowisko .NET w wersji 4.6.1. 

## Cel powstania aplikacji
Aplikacja powstała podczas drugiego etapu rekrutacji do jednej z największych firm informatycznych w Polsce na stanowisko Juniora. Miała ona na celu sprawdzenie moich umiejętności programistycznych, a także sposób radzenia sobie z niebanalnymi problemami.

## Założenia projektowe
Aplikacja powinna wczytać obraz z pliku tekstowego o określonym formacie w jak najkrótszym czasie. 
<p>Format pliku:<br>
Plik wejściowy to klasyczny plik tekstowy, którego każdy wiersz (zakończony znakiem nowej linii) opisuje jeden piksel. Zapis postaci pojedyńczego piksela opisany jest poniżej:</p>

<p>XX,YY:R,G,B gdzie:</p>
<ul>
  <li>XX - pozycja X piksela (liczba całkowita)</li>
  <li> YY - pozycja Y piksela (liczba całkowita)</li>
  <li> R - składowa Red koloru piksela (liczba całkowita)</li>
  <li> G - składowa Green koloru piksela (liczba całkowita)</li>
  <li> B - składowa Blue koloru piksela (liczba całkowita)</li> 
</ul>
<p>
Przykład:<br>
1,1:253,253,253<br>
1,2:251,251,251<br>
1,3:253,253,253<br>
1,4:253,253,253<br>
1,5:251,251,251<br>
1,6:251,251,251<br>
...<br>
Przykładowy plik do wczytania to sample.txt
</p>

Zadanie rekrutacyjne polegające na utworzeniu wizualnej aplikacji, której zadaniem jest wygenerowanie (w jak najkrótszym czasie) obrazu na podstawie wczytanego pliku o określonym formacie.


## Działanie aplikacji
![Menu kontekstowe](https://github.com/lykoszczan/Zadanie-rekrutacyjne/blob/master/Zadanie%20rekrutacyjne/screenshots/main.png?raw=true) <p>
  Opis menu: <br>
  <ul>
    <li>Nowy - czyści zawartość ekranu</li>
    <li>Otwórz - otwiera plik tesktowy i wyświetla obraz na podstawie algorytmu</li>
    <li>Zapisz obraz jako ... - zapisuje wczytany obraz jako plik PNG</li>
  <li>Kowertuj obraz do pliku ... - konwertuje wczytany obraz do pliku tekstowego</li>
    <li>Wyjście - zamyka aplikację</li>
</ul>

<p>Aby otworzyć obraz należy wybrać opcję otwórz i następnie wybrać plik txt</p>

![Menu kontekstowe](https://github.com/lykoszczan/Zadanie-rekrutacyjne/blob/master/Zadanie%20rekrutacyjne/screenshots/otwieranie.png?raw=true)

<p>Wczytany obraz prezentuje się następująco:</p>

![Menu kontekstowe](https://github.com/lykoszczan/Zadanie-rekrutacyjne/blob/master/Zadanie%20rekrutacyjne/screenshots/wynik.png?raw=true) 

## Modyfikacje
<p> W wymaganiach projektu nie było uwzględniona, aby aplikacja potrafiła również działać "w drugą stronę" tzn. żeby potrafiła przekonwertować obraz do pliku tekstowego. Jednakże wydawało mi się to dość logiczną opcją i w ramach rozwoju własnych umiejętności postanowiłem ją dodać. Aby się o tym przekonać wystarczy uruchomić ją z menu głównego i postępować tak jak przy normalnym otwieraniu plików </p>

## Kontakt
<p> W razie jakichkolwiek pytań proszę się kontaktować pod mailem <a href="mailto: lykoszczan@gmail.com">lykoszczan@gmail.com</a></p>
