# Mål
Detta är en felsökningsaktivitet för att förstå kod och logikflöde. Jag kommer att logga felen och vad jag gjorde för att lösa dem.

# Fel och lösningar
## 1. Ohanterat undantag i ShoppingList.cs
Fel Locus:rad 90
Löst av: Tog bort en tom rad i items.txt (rad 4)

## 2. Strängargument i Program.cs
Fel Locus:rad 2
Löst av: Tog bort en tom rad i items.txt (rad 4)

## 3. Meny laddar utan att visa de första två varor/rad
Fel Locus: ShoppingList.cs, Load funktion, rad 81-113
Löst av: Skrev om Load() att fixa saknade-fil krash

## 4. Total skippa första varan
Fel Locus: ShoppingList.cs, Total() funktion, rad 24-34
Löst med att: Byt metod i Total() funktion från en "int" till "long"

## 5. Att Spara döljer misslyckor pga empty catch { }
Fel Locus: ShoppingList.cs, Save() funktion, rad 74-76
Löst av: Skrev om Save() att fånga och rapportera misslyckor med try att spara listan och catch error meddelande

## 6. Ogiltigt nummer orsaker krasch pga RemoveAt
Fel Locus: ShoppingList.cs, RemoveAt() funktion
Löst med att lägga till i: 
1. Shopping List.cs en bool metod, rad 18-22
2. Program.cs en if funktion att skriva ogiltigt nummer, rad 30-33