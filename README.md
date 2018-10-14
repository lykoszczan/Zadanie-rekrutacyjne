# Zadanie-rekrutacyjne
Zadanie rekrutacyjne polegające na utworzeniu wizualnej aplikacji, której zadaniem jest wygenerowanie (w jak najkrótszym czasie) obrazu na podstawie wczytanego pliku o określonym formacie.




Opis menu:
  - Nowy - czyści zawartość ekranu
  - Otwórz - otwiera plik tesktowy i wyświetla obraz na podstawie algorytmu
  - Zapisz obraz jako ... - zapisuje wczytany obraz jako plik PNG
  - Kowertuj obraz do pliku ... - konwertuje wczytany obraz do pliku tekstowego (ta opcja nie była wymagana w zadaniu, był to mój dodatek)
  - Wyjście - zamyka aplikację
Format pliku:
Plik wejściowy to klasyczny plik tekstowy, którego każdy wiersz (zakończony znakiem nowej linii) opisuje jeden piksel. Zapis postaci pojedyńczego piksela opisany jest poniżej:
      XX,YY:R,G,B gdzie:
- XX - pozycja X piksela (liczba całkowita)
- YY - pozycja Y piksela (liczba całkowita)
- R - składowa Red koloru piksela (liczba całkowita)
- G - składowa Green koloru piksela (liczba całkowita)
- B - składowa Blue koloru piksela (liczba całkowita)

Przykład:

1,1:253,253,253

1,2:251,251,251

1,3:253,253,253

1,4:253,253,253

1,5:251,251,251

1,6:251,251,251

...

Przykładowy plik do wczytania to sample.txt
