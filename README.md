C# Övningssamling - Inkapsling, arv och polymorfism
 Löpande i uppgifterna finns några kunskapsfrågor (startar med “F:”). Dessa frågor besvaras som
 kommentarer i koden. Koden behöver inte ta emot input från en användare.
 3.1) Inkapsling
 1. Skapa en klassPersonoch ge den följande privata fält:
 age, fName, lName, height, weight
 Skapa publika properties med get och set som hämtar eller sätter tilldelad variabel.
 Instansiera en person i Program.cs, kommer du direkt åt variablerna?
 Implementera validering i de skapade properties:
 ● Age kan bara tilldelas ett värde större än 0.
 ● FName är obligatorisk och får inte vara mindre än 2 tecken eller längre än 10
 tecken.
 ● LName är obligatorisk och får inte vara mindre än 3 tecken eller större än 15
 tecken.
 Kasta ett undantag av typen ArgumentException i varje property om dess
 validering inte fullföljs, undantaget ska innehålla ett beskrivande
 meddelande.
 Se till att hantera undantagen i Program-klassen med en try-catch block.
 2. För att inkapsla Person-objekten ytterligare skall vi skapa klassen PersonHandler
en klass vars syfte är att skapa och hantera dina Person-objekt.
 I PersonHandler-klassen skapa metoden:
 public void SetAge(Person pers, int age)
 Använd den inskickade personens Age property för att sätta personens age-attribut
 via SetAge-metoden. Istället för att enbart använda en property har vi nu
 abstraherat med två lager.
 3. IPersonHandler, skriv en metod som skapar en person med angivna värden:
 public Person CreatePerson(int age, string fname,
 string lname, double height, double weight)
 4. Fortsätt skapa metoder i PersonHandler för att kunna hantera samtliga
 operationer som man kan vilja göra med en Person.
5. När denna klass är klar, kommentera bort er tidigare instans av Person från
 Program.cs, och instansiera istället en PersonHandler. Skapa därigenom några
 personer och testa era metoder.
 3.2) Polymorfism
 1. Skapa den abstrakta klassen UserError
 2. Skapa den abstrakta metodenUEMessage() som har returtypenstring.
 3. Skapa en vanlig klass NumericInputError som ärverfrånUserError
 4. Skriv enoverride för UEMessage()så att den returerar“You tried to use a
 numeric input in a text only field. This fired an error!”
 5. Skapa en vanlig klass TextInputError som ärver frånUserError
 6. Skriv enoverride förUEMessage()så att den returerar “You tried to use a text
 input in a numeric only field. This fired an error!”
 7. I Program.cs Main-metod: Skapa en lista med UserErrors och populera den med
 instanser av NumericInputError ochTextInputError.
 8. Skriv ut samtliga UserErrors UEMessage() genom enforeach loop.
 9. Skapa nu tre egna klasser med tre egna definitioner på UEMessage()
 10. Testa och se så det fungerar.
