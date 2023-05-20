using PDF;

// Instanciation des poules 
Poule Ginger = new Poule("Ginger", "Gauloise", 0.8, Taille.L);
Poule Pathan = new Poule("Pathan", "Golmon", 10, Taille.XXL);
Poule Paymeric = new Poule("Paymeric", "Gauloise", 1.5, Taille.XL);
Poule Pevann = new Poule("Pevann", "La Coucou de Rennes", 3, Taille.S);
Poule Tchikita = new Poule("Tchikita", "La Vorwerk", 1.2, Taille.M);
Poule Passim = new Poule("Passim", "La Marans", 0.4, Taille.M);


// Instantation du poulailler "LeGangDesPoules 
Poulailler LeGangDesPoules = new Poulailler("LeGangDesPoules", 6);

// Ajoute des poules dans le poulailler LeGangDesPoules
LeGangDesPoules.Ajouter(Pathan);
LeGangDesPoules.Ajouter(Tchikita);
LeGangDesPoules.Ajouter(Passim);
LeGangDesPoules.Ajouter(Pevann);
LeGangDesPoules.Ajouter(Paymeric);
LeGangDesPoules.Supprimer(1);


// Affichage les poules présent dans le poulailler LeGangDesPoules
LeGangDesPoules.AfficherPoulailler();







