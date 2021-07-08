﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Party_Bud
{
    class NeverHaveIQuestionSet
    {
        public string[] Setup()
        {
            var random = new Random();
            random.Shuffle(questions);
            return questions;
        }

        string[] questions = new string[] {
            "ønsket å bli astronaut.",
            "knullet mitt eget hår opp med hjemmefarge",
            "sett hver episode av Friends",
            "hatt sex med noen som veide mer enn meg selv",
            "vært vegetarianer.",
            "brukt øyenvippe",
            "røykt en sigarett.",
            "gått på etter skolen.",
            "tisset i en søppelbøtte",
            "tisset i dusjen.",
            "spist mat som har falt ned på gulvet.",
            "googlet en forelskelse og luket ham ut på grunn av det jeg fant.",
            "hatt sex",
            "invitert en jente til Netflix og chill",
            "hatt kjæresteomsorg",
            "sunget i badekaret",
            "gått på high school.",
            "klandret et dyr for prompen min.",
            "gått på mer enn en uke uten å dusje.",
            "sett Harry Potter-filmene.",
            "vært på date.",
            "tatt et nakenbilde",
            "hatt mareritt etter å ha sett en skrekkfilm",
            "vært forelsket i en i dette rommet.",
            "jobbet i et supermarked",
            "jukset på",
            "hatt sex med en person fra Sjælland",
            "i mitt liv spilt Fifa",
            "gått tilbake til en eks.",
            "skrevet med en bare fordi jeg kjedet meg.",
            "vært i håndjern",
            "vinket til en fremmed som vinket til en som gikk bak meg.",
            "ødelagt noe.",
            "farget håret mitt",
            "onanert mer enn 3 ganger på en dag",
            "truffet en fis som var litt mer enn bare en fis",
            "flørtet eller grått meg ut av en togbillett / fartsbot osv.",
            "tisset i sengen (som voksen)",
            "hatt en skjønnhetsoperasjon.",
            "løpt fordi jeg var redd for mørket (som voksen)",
            "latet som om jeg vasket hendene etter et toalettbesøk ved å slå på vannet – uten å vaske hendene",
            "hatt en one night stand",
            "vandalisert",
            "krasjet med bil",
            "lastet ned en dating-app",
            "mistet lommeboka",
            "hatt fartsbot.",
            "hatt sex på en strand",
            "hatt sex med noen som veide mer enn 80 kg",
            "tisset i badekaret.",
            "kysset med mer enn tre på en natt",
            "løyet for foreldrene mine.",
            "satt på musikk hjemme og danset alene.",
            "sviktet en handel.",
            "hatt sex med noen utenfor Danmark.",
            "lagt ut en Super Like på Tinder",
            "ligget med 3 forskjellige mennesker i løpet av en uke",
            "veltet på sykkel",
            "gått til speider",
            "hatt sex med noen i dette rommet.",
            "sagt 'jeg elsker deg' til et annet menneske.",
            "tenkt på en annen person mens jeg hadde sex med en kjæreste",
            "spist et helt glass nutella på under en time",
            "vært naken på et diskotek.",
            "trukket den samme matemballasjen ut av søpla mer enn en gang, for å se instruksjonene igjen",
            "angret på at jeg hadde sex med noen.",
            "prompet og klandret noen andre.",
            "slettet et bilde på Instagram fordi jeg trodde det fikk for få likes",
            "vært forelsket i en vert fra TV-avisen.",
            "klippet mitt eget hår",
            "gitt penger til en hjemløs person.",
            "hatt sex på et kjøkkenbord",
            "baktalt venninnene mine.",
            "sendt en frekk beskjed.",
            "klippet mine egne hår smell",
            "vært avhengig av noe.",
            "jukset i ludo eller et annet spill",
            "spilt sannhet eller tør",
            "hatt vondt i magen ved å holde en fis / dritt inne mens jeg var sammen med noen jeg elsket.",
            "satt mitt eget hår eller noen andres hår i brann.",
            "forfulgt en eks-kjærestes nye kjæreste på sosiale medier",
            "kastet opp offentlig i en brann.",
            "spist fisk",
            "vært på en blind date.",
            "sett på barne-TV, selv om jeg er voksen.",
            "vært på skolen.",
            "spist på en restaurant, hvoretter jeg har gått av regningen",
            "hatt en kjønnssykdom.",
            "bundet en øl",
            "spist søtsaker eller chips til frokost",
            "trodd på et liv etter døden.",
            "stjålet",
            "kysset noen av samme kjønn.",
            "vært på ferie med venninnene mine",
            "sittet og sett Ramasjang-figurene sove litt lenger enn det gir mening",
            "gått en 'skammens vandring'",
            "gitt en lapdance",
            "hatt en kjæreste",
            "vært på en festival.",
            "hatt sex med noen jeg bare hadde kjent på mindre enn en time.",
            "sett Game of Thrones",
            "hatt voksing i bikinilinjen.",
            "blitt tatt for å ha sex med foreldrene mine",
            "ønsket å bli skuespiller",
            "kastet noe som brøt seg inn i raseri.",
            "hatt massasje.",
            "blitt skadet i en brann.",
            "angret på at jeg slo opp med en ekskjæreste.",
            "prøvd å ta viagra",
            "gått inn i noe eller falt fordi jeg har gått med nesen på telefonen",
            "vært utro mot deg.",
            "hatt 12 i en handel",
            "hatt sex med noen av samme kjønn.",
            "hatt sex med noen fra klassen min.",
            "vært i solsengen.",
            "gitt feil nummer til en fyr med vilje.",
            "spart på en hest",
            "klappet en løve",
            "kastet opp på et offentlig sted.",
            "vært i fengsel.",
            "vært i slåsskamp.",
            "vært bartender.",
            "sett på en annen persons meldinger",
            "forfalsket en orgasme",
            "vært en kutter",
            "kysset noen av samme kjønn.",
            "vært full på en ukedag",
            "sett Paradise Hotel",
            "vært i London.",
            "fått noe stjålet.",
            "vært redd for mørket.",
            "blitt scoret av noen på et diskotek.",
            "grått om en Disney-film.",
            "hatt sex mens det var noen andre i rommet.",
            "løyet om en ulykke/død i familien, for å komme meg ut av time/hjem fra jobb",
            "gått en hel dag uten undertøy",
            "sovet på skolen.",
            "slått ned en annen person i byen.",
            "spydd foran foreldrene mine.",
            "vært så full at jeg ikke husket noe.",
            "hatt en trekant.",
            "vært forelsket i noen jeg har vært i klassen med.",
            "hatt en frekk fantasi om en venns eller venns mor eller far",
            "hatt sex i en heis",
            "vært avhengig av kokain.",
            "forfulgt en annen person på Facebook",
            "grått for en gråtende film.",
            "klappet en hest",
            "vært forelsket i noen som var +5 år eldre enn meg",
            "sunget og spilt den inn for å høre min egen sangstemme",
            "laget en 'lyn-1-2-3 unna' (dyttet alt rotet ditt inn i et skap fordi du var opptatt)",
            "hatt sex på et offentlig sted",
            "sett Avatar",
            "forfalsket i sengen",
            "kysset noen i dette rommet.",
            "vært på konsert.",
            "gått inn i en lyktestolpe.",
            "løyet for kjæresten min.",
            "vært i en sport",
            "stappet toalettpapir i trusen fordi jeg ikke hadde et bind tilgjengelig.",
            "spist to pizzaer på rad",
            "stjålet noe (ikke nødvendigvis med vilje)",
            "filmet meg selv å ha sex",
            "fått en tatovering",
            "vært sammen med en som er yngre enn meg selv.",
            "løyet for venninnene mine.",
            "sett en Fifty Shades-film på kino.",
            "brukt intim såpe",
            "sett faren min naken.",
            "fantasert om noen andre under sex",
            "vært utenfor EU",
            "hatt en venn.",
            "likt Piña Colada",
            "twerked",
            "danset på bordene.",
            "kysset noen jeg ikke visste navnet på.",
            "kranglet med en politimann.",
            "sett porno.",
            "vært forelsket i Channing Tatum.",
            "tatt en graviditetstest",
            "meldt meg på et realityshow.",
            "hatt sex med noen jeg ikke visste navnet på.",
            "stjålet noe.",
            "sovnet under en film."
        };
    }
}