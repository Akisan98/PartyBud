﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Party_Bud
{
    class TruthQuestionSet
    {
        public string[] Setup()
        {
            var random = new Random();
            random.Shuffle(questions);
            return questions;
        }

        string[] questions = new string[] {
            "Hva er det første du ville ha gjort hvis du våknet opp som det motsatte kjønn?",
            "Har du noen gang latt noen andre ta skylden for noe du gjorde?",
            "Hva er det mest pinligste tingen du noen gang har gjort?",
            "Hva er den mest latterlige grunnen til at du noen gang har slått opp med noen over?",
            "Hva synes du er din beste evne? Og hva er det verste?",
            "Hva er det modigste du noen gang har gjort?",
            "Hvis du må tjene pengene dine ulovlig, hvordan ville du da tjent dem?",
            "Hva er noe barnslig som du fortsatt gjør?",
            "Hvis du var blind, hvem (herfra) ville da være førerhunden din?",
            "Hva kan imponere deg mest?",
            "Hvis du bare kan bruke 3 ord resten av kvelden - hva ville de være?",
            "Hvis du var en diktator, hvilken lov ville du laget først?",
            "Hva var den mest pinlige opplevelsen din?",
            "Hva var den største tabben du gjort i livet ditt?",
            "Hva ville du aldri gjort - selv om du bare har 12 timer til å leve?",
            "Fortell en hemmelighet fra barndommen din.",
            "Hvem har du hatt den største crushen på?",
            "Har du noen gang vært forelsket i en av de som er her nå?",
            "Hvis du var en vampyr, hvem (av oss) ville du bitt nå?",
            "Hva er det verste du noen gang har opplevd?",
            "Hva er din mørkeste fantasi?",
            "Hva liker du mest med kroppen din og hva like du minst?",
            "Hvem av oss vil du se naken?",
            "Hvem i omgangen kunne du bli forelsket i mest?",
            "Hvis du skulle tatovere deg selv i underlivet - hva ville det være?",
            "Hva er viktigere i et forhold - sex eller kjærlighet?",
            "Synes du sex er kult, bra, greit, noen ganger fint - eller er det ikke så viktig for deg?",
            "Hva er det som gjør deg virkelig god på sex?",
            "Hvor mange ganger i uken / måneden har du sex - og hvor ofte vil du ha sex?",
            "Hvor mange forskjellige sexpartnere har du allerede hatt?",
            "Hvilken del av kroppen tenner deg mest?",
            "Hvordan, hvor og med hvem hadde du din første gang (sex)?",
            "Hvor viktig er et utvidet forspill for deg?",
            "Hva må en mann / kvinne gjøre for å forføre deg?",
            "Har du noen gang hatt et trekant? Og hvordan likte du det?",
            "Har du noen gang hatt sex med en god venn?",
            "Har du noen gang hatt sex med en av denne gruppen - bortsett fra partneren din?",
            "Hva er det mest pinlige øyeblikket i sex du noen gang har hatt?",
            "Hva ser du etter hos en kvinne først - bryster, rumpe eller ansikt?",
            "Hva ser du etter hos en mann først, og hva må han ha slik at du tenker: awwwww, kult!",
            "Hva er din favorittposisjon under sex?",
            "Hva er et absolutt tabu under sex?",
            "Hva er det hotteste du noen gang har gjort?",
            "Har du noen gang hatt cybersex eller telefonsex - og med hvem?",
            "Hva er bedre - barbert eller ikke-barbert (nedentil)?",
            "Hvem i denne gruppen synes du har den beste sexen?",
            "Hvem vil du gi penger til å sove hos deg?",
            "Hva var din sykeste sexopplevelse?",
            "Har du noen gang hatt farlig sex - og hvordan var det egentlig?",
            "Har du noen gang hatt sex med en fremmed? f.eks fra Tinder?",
            "Har du noen gang hatt sex med samme kjønn?",
            "Du hadde sex med meg. Hva vil du si til meg etterpå?",
            "Hvem hadde du livets beste sex med?",
            "Har du noen gang betalt for sex?",
            "Hvem hadde du din siste hete drøm om?",
            "Har du noen gang blitt overrasket under sex - og av hvem?",
            "Hvor er din erogene sone?",
            "Hvem vil du ha sex med?",
            "Hvor har du intime piercinger?",
            "Hvor mange menn / kvinner har du allerede kysset?",
            "Hvem hadde du den hotteste daten med?",
            "På toalettet: Brette eller rulle toalettpapiret?",
            "Hvor barberer du deg?",
            "Har du noen gang hørt søsteren / broren din stønne?",
            "Er du alltid tro (mot kjæresten)?",
            "Hvilken kjendis vil du ha en date med?",
            "Hvilken munn liker du mest fra gruppen her?",
            "Hvilken spiller har de vakreste hendene?",
            "Hvor var ditt første kyss?",
            "Hvem i gjengen vil du aller mest kysse?",
            "Hvem ved bordet er nok den mest kranglete?",
            "Har noe flaut skjedd med deg på en date?",
            "Har du noen gang hatt kontakt med narkotika?",
            "Har du noen gang jukset på skoleeksamen?",
            "Har du noen gang stjålet noe tidligere?",
            "Snorker du om natten?",
            "Hvilken er favorittsangen din?",
            "Med hvilken spiller vil du bytte livet med i en uke, og hvorfor?",
            "Du flytter til en ensom øy, hvem fra runden tar du med deg?",
            "Hva er du mest redd for?",
            "Har du et kallenavn?",
            "Ser du inn i toalettskålen før du skyller?",
            "Hvem ga deg den verste hjertesorgen?",
            "Hvor mange typer / jenter har du allerede kysset?",
            "Hvem er du forelsket i?",
            "Hvilket dyr passer deg best, og hvorfor?",
            "Hva var din verste date?",
            "Hvem vil du kysse nå?",
            "Vil du heller tatovere rumpa eller pierce tungen?",
            "Hvilken kjent person vil du overnatte sammen med?",
            "Du må gifte deg med en stjerne, hvem?",
            "Hvordan / hvor / med hvem var ditt første kyss?",
            "Hvilken frisyre har du i kjønnsområdet?",
            "Er du nysgjerrig på å bli intim med en person av ditt eget kjønn?",
            "Elsker du et langt forspill? Hvordan skal det i så fall se ut?",
            "Hva tenker du på når du tilfredsstiller deg selv?",
            "Når var din første gang?",
            "Er du fortsatt jomfru?",
            "Har du noen gang blitt fanget i onani?",
            "Har du noen gang stappet BH-en din?",
            "Når var sist gang du hadde sex?",
            "På hvilke steder har du onanert?",
            "Har du noen gang hatt sex utendørs?",
            "Har du noen gang vært intim med 2 personer på samme tid?",
            "Hva er din hemmelige, mørke fantasi?",
            "Vil du la deg bli sprutet på av en mann i ansiktet?",
            "Har du allerede hatt homoseksuelle opplevelser?",
            "Hvem synes du er penest i gjengen? (Sorter alle mennesker fra søte til stygge - Eller ikke).",
            "Hvem fra denne runden ville du IKKE invitere til neste fest?",
            "Hva var den siste løgnen du fortalte personen til høyre for deg?",
            "Hva var ditt største ønske som du aldri sa?",
            "Tisser du i dusjen / Har du noen gang tisset i dusjen?",
            "Hvilken barnslig oppførsel har du i dag?",
            "Hva er din største frykt som ingen vet om?",
            "I hvem har du noen gang vært forelsket, som ingen vet om?",
            "Har du noen gang fylt på BH-ene eller trusen?",
            "Vil du helst være stygg og populær eller pen og upopulær?",
            "Hvilken stilling liker du best?",
            "Hvis du kunne være usynlig, hva er det første du ville gjort?",
            "Hva er en hemmelighet du holdt for foreldrene dine?",
            "Hva er den mest pinlige musikken du hører på?",
            "Hva er en ting du skulle ønske du kunne endre med deg selv?",
            "Hvem er din hemmelige forelskelse?",
            "Hvem er den siste personen du stalket på sosiale medier?",
            "Hvis en genie ga deg tre ønsker, hva ville du be om?",
            "Hvor er det rareste stedet du noen gang har gått på do?",
            "Hvilken spiller ville overleve en zombie -apokalypse, og hvilken ville være den første som gikk?",
            "Hvilken unnskyldning har du brukt før for å baile på planer med en venn?",
            "Hva er det lengste du noen gang har sovet?",
            "Les det siste du sendte din beste venn eller betydningsfulle andre høyt.",
            "Når løy du sist?",
            "Hvilke fem ting ville du ta med til en øde øy?",
            "Hva er det mest pinlige du noen gang har gjort på en date?",
            "Hva er den galeste pickup -linjen du noen gang har brukt?",
            "Hvilket dyr tror du du ser mest ut som?",
            "Hvor mange selfies tar du om dagen?",
            "Hva er en ting du ville stå i kø i en time?",
            "Når var siste gangen du gråt?",
            "Hva er den mest pinlige toppspillede sangen på telefonen din?",
            "Hva var ditt favoritt barndomsprogram?",
            "Hvis du kunne være en fiktiv karakter for en dag, hvem ville du valgt?",
            "Hva er din største frykt?",
            "Hva er en dum ting du ikke kan leve uten?",
            "Hva er den rareste trenden du noen gang har deltatt i?",
            "Hvis du bare kunne høre på en sang resten av livet, hva ville du valgt?",
            "Hvilken person skriver du mest til?",
            "Har du noen gang fått sparken fra en jobb?",
            "Hva er en øyeblikkelig dealbreaker i en potensiell kjærlighetsinteresse?",
            "Hvis du bare kunne spise en ting resten av livet, hva ville du valgt?",
            "Hva er den største løgnen du noen gang har fortalt foreldrene dine?",
            "Hva er den verste fysiske smerten du noen gang har opplevd?",
            "Hvilken spiller kjenner deg best?",
            "Hva er din favorittdel av kroppen din?",
            "Hva er det rareste du noen gang har spist?",
            "Hvem er din kjendisforelskelse?",
            "Hva er den merkeligste drømmen du noen gang har hatt?",
            "Hva er de tre viktigste tingene du ser etter hos en kjæreste/kjæreste?",
            "Hva er din verste vane?",
            "Hvor mange kosedyr eier du?",
            "Hva er din største usikkerhet?",
        };
    }
}
