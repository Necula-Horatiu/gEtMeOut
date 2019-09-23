# gEtMeOut

Aplicatie web care bazandu-se pe interesele tale iti arata toate concertele din jurul tau pe o anumita raza

## Apis

### UserController

#### api/user - get
- Intoarce toti userii din baza de date

#### api/user - post
- Primeste un model de tip user
- Adauga noul user in baza de date

#### api/user/login - post
- Primeste credentialele de logare
- Intoarce user in cazul in care credentialele sunt corecte
- Intoarce 0 in cazul in care userul nu se afla in baza de date

##

### EventController

#### api/event/{km} - post
- Primeste id-ul unui user
- Intoarce toate evenimentele de interes pentru acel user pe o raza de {km} km

#### api/event/money/{km} - post
- Primeste un model de tip moneyModel
  - UserId
  - MinMoney
  - MaxMoney
- Intoarce toate evenimentele de interse pentru un user in intervalul de bani

#### api/event/favorite - post
- Primeste id-ul unui user
- Intoarce toate evenimentele sale favorite

#### api/event/popular - post
- Intoarce toate evenimentele populare.
  - Popularitatea se masoara in functie de numarul de user care au adaugat evenimentul la favorite

##

### FavEventController

#### api/favevent - post
- Primeste un model de tipul favEvent
  - IdUser
  - IdEvent
- Adauga un eventul IdEvent la favorite pentru userul IdUser

#### api/favevent/notify - post
- Primeste un model de tipul favEvent
  - IdUser
  - IdEvent
- Notifica un user in cazul in care mai este mai putin de 1.5h pana la unul dintre evenimentele lui favorite

#### api/favevent - delete
- Primeste un model de tipul favEvent
  - IdUser
  - IdEvent
- Sterge un eveniment de la favorite