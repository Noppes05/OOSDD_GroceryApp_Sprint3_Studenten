# Git Flow Workflow

Dit project gebruikt **Git Flow** als branching-strategie. Git Flow helpt ons om features, releases en hotfixes gestructureerd te beheren.

## Branches

In Git Flow zijn er een paar vaste branches:

- **main**  
  Bevat altijd de productierijpe code. Alles op `main` is **stabiel** en kan gedeployed worden.

- **develop**  
  Bevat de laatste ontwikkelstatus. Nieuwe features worden hier samengevoegd.

Daarnaast worden tijdelijke branches gebruikt:

- **feature/**  
  Voor nieuwe functionaliteiten.  
  Naamgeving: `feature/omschrijving`  
  → Gebaseerd op `develop` en wordt terug gemerged in `develop`.

- **release/**  
  Voor het voorbereiden van een nieuwe release (bugfixes, documentatie, kleine aanpassingen).  
  Naamgeving: `release/x.y.z`  
  → Gebaseerd op `develop` en wordt gemerged in zowel `main` als `develop`.

- **hotfix/**  
  Voor urgente fixes op productie.  
  Naamgeving: `hotfix/x.y.z`  
  → Gebaseerd op `main` en wordt gemerged in zowel `main` als `develop`.



# GroceryApp sprint3 Studentversie  
    
## UC07 Delen boodschappenlijst  
Is compleet  
  
## UC08 Zoeken producten  
Aanvullen:
- In de GroceryListItemsView zitten twee Collection Views, namelijk één voor de inhoud van de boodschappenlijst en één voor producten die je toe kunt voegen aan de boodschappenlijst  
- Voeg boven de tweede CollectionView een zoekveld (SearchBar) in om op producten te kunnen zoeken.  
- Zorg dat de SearchCommand wordt gebonden aan een functie in het onderliggende ViewModel (GroceryListItemsViewModel) en dat de zoekterm die in het zoekveld is ingetypt gebruikt wordt als parameter (SearchCommandParameter).  
- Werk in het viewModel (GroceryListItemsViewModel) de zoekfunctie uit en zorg dat de beschikbare producten worden gefilterd op de zoekterm!  

## UC09 Registratie gebruiker 
Aanpassen:
- Toevoegen van registratie View, inclusief ViewModel.
- Register functie in viewmodel maken en Binden met de knop 'Registreren'. niet vergeten om het wachtwoord te hashen.
- Toevoegen van add functie in ClientRepository.
- button plaatsen op log in scherm om naar registratie view te gaan.
- **Belangrijk** goed checken of velden zijn ingevuld en checken of email niet al gebruikt is door een andere gebruiker
  

