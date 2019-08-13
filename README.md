# gEtMeOut

Aplicatie web care bazandu-se pe interesele tale iti arata toate concertele din jurul tau pe o anumita raza

## Apis

### UserController

#### api/user - get
Intoarce toti userii

#### api/user - post
Adauga un user nou

### EventController

#### api/event/{km} - post
Intoarce toate evenimentele tale de interes pe o raza de {km} km

#### api/event/favorite - post
Intoarce toate evenimentele tale favorite

### FavEventController

#### api/favevent - post
Adauga un event la favorite

#### api/favevent/notify - post
Notifica un user in cazul in care mai este mai putin de 1.5h pana la unul dintre evenimentele lui favorite

#### api/favevent - delete
Sterge un eveniment de la favorite