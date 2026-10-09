# Mål
Detta är en felsökningsaktivitet för att förstå kod och logikflöde. Jag kommer att logga felen och vad jag gjorde för att lösa dem.

# Fel och lösningar
## 1. Ohanterat undantag i ShoppingList.cs
Locus:rad 90
Löst av: Tog bort en tom rad i items.txt

## 2. Strängargument i Program.cs
Locus:rad 2
Löst av: Tog bort en tom rad i items.txt

## 3. Meny laddar utan att visa de första två varor/rad
Locus: ShoppingList.cs rad 81-113
Löst av: Skrev om Load() att fixa saknade-fil krash

## 4. Total skippa första varan
Locus: ShoppingList.cs rad 24-34
Löst med att: Byt metod från en "int" till "long"

## 5. 