

# e-Agro
## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Sara Martinović| smartinov@foi.hr | 0016134684 | saramartinovic
Karolina Kolak| kkolak@foi.hr | 0016131336 | kkolak
Ivan Martinović | imartinov@foi.hr | 0016130092 | imartinov

## Opis domene
Prema izvoru bliskom nama koji radi u tvrtci Agronom, znamo da sustavi za prodaju, izradu ponuda i skladištenje nisu previše razvijeni. Oni koriste zasebne programe za različite radnje te su ti programi zastarjeli. To nam je bio izvor ideje te smo odlučili ovom aplikacijom modernizirati njihov i spojiti sve funkcionalnosti u jednu aplikaciju. 
Unutar aplikacije će postojati nekoliko uloga, a to su: admin, skladištar i prodajni referent. 
Raspored funkcionalnosti prema ovim ulogama je idući:
Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Sara Martinović| smartinov@foi.hr | 0016134684 | saramartinovic
Karolina Kolak| kkolak@foi.hr | 0016131336 | kkolak
Ivan Martinović | imartinov@foi.hr | 0016130092 | imartinov

Naziv uloge | Funkcionalnosti
----------- | ---------------
Admin | dodavanje korisnika, kreiranje skladišta i ureda, dodavanje zaposlenika u skladišta i urede
Skladištar | izrada i ispis otpremnice, izrada i ispis primke, kreiranje izvještaja
Prodajni referent | upravljanje katalogom strojeva, izrada i ispis ponude, slanje ponude e-mailom klijentu, dodavanje klijenata, kreiranje grafova

Ovakvo softversko rješenje bi se moglo koristiti i u tvrtkama sličnim ovoj, koji se bave prodajom i skladištenjem poljoprivredne mehanizacije. 

## Specifikacija projekta
Aplikacija se dizajnira u programskom jeziku C# u obliku Windows forme koja će biti namijenjena za Windows operacijski sustav. Bazu podataka kreirat ćemo u MS SQL Serveru te ćemo s podacima iz baze raditi u aplikaciji. Izradom ove aplikacije olakšat ćemo proces kreiranja ponuda, prodaje i skladištenja strojeva. 

Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Dodavanje korisnika | Kako bi korisnici imalipristup aplikaciji, potrebno ih je dodati te im dodijeliti pripadajuću ulogu. | Ivan Martinović
F02 | Prijava u sustav | Za pristup aplikaciji korisnici će imati mogućnost login-a, ti podaci će im biti dodijeljeni nakon što ih admin doda u sustav. | Ivan Martinović 
F03 | Kreiranje skladišta i ureda | U aplikaciji će postojati popis zaposlenika te popis strojeva na skladištu te su nam zato potrebni uredi i skladišta. | Karolina Kolak
F04 | Dodavanje zaposlenika u skladište i urede | Nakon što su kreirani uredi i skladišta, potrebno je zaposlenike raspodijeliti prema skladištima i uredima na kojima su oni zaposleni. | Karolina Kolak
F05 | Upravljanje katalogom strojeva | Za izradu ponuda klijentima potreban nam je popis svih strojeva u katalogu te mogućnost dodavanja ili brisanja strojeva. | Sara Martinović
F06 | Izrada i ispis ponude | Prema popisu strojeva iz kataloga, oni će se dodavati u ponudu prema zahtjevima kupaca danim prodajnom referentu. Prije slanja ponude, potreban nam je ispis kako bi imali uvid u samu ponudu radi provjere. | Ivan Martinović
F07 | Slanje ponude e-mailom klijentu | Nakon što je ponuda kreirana, potrebno ju je poslati klijentu. Najbrži način da ponuda stigne do klijenta je putem e-maila. | Ivan Martinović
F08 | Izrada i ispis otpremnice | Prilikom prodaje stroja, skladištar sastavlja otpremnicu prema kojoj se obavlja smanjenje stroja na skladištu. | Sara Martinović
F09 | Izrada i ispis primke | Kada klijent pristane na ponudu, prodajni referent naručuje stroj i kada stroj stigne na skladište, pojavljuje se dokument naziva primka. Prema primki se povećava stanje stroja na skladištu. | Karolina Kolak
F10 | Dodavanje klijenata | Unutar aplikacije bi se vršila evidencija klijenata prema prodajnim referentima i kupljenim strojevima. | Sara Martinović
F11 | Kreiranje izvještaja | Radi evidencije, potrebna je izrada izvještaja. U izvještajima bi bilo vidljivo koji su strojevi u skladištima te u kojim skladištima. | Karolina Kolak
F12 | Kreiranje grafova | Kako bi prodajni referent pratio svoje uspjehe, ali kako bi i tvrtka mogla nagraditi najuspješnije radnike, pomoću grafova je vidljivo koliki je profit ostvario koji radnik te koju vrstu stroja je najviše prodao. | Sara Martinović

## Tehnologije i oprema
MS Visual Studio, MS SQL Server, MS Office, MS Project, programski jezik C#, framework .NET, GitHub, Differ..
