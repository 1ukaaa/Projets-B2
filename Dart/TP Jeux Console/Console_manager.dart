import 'NE_PAS_TOUCHER/user_input.dart';
import 'bot.class.dart';
import 'dart:math';
import 'player.class.dart';
import 'character.class.dart';

String askNickName() {
  var pseudo = "";
  do {
    pseudo = readText("Quel est votre nom aventurier ?");
  } while (pseudo.length < 3);
  return pseudo;
}

void awaitPlayer() {
  var input;
  do {
    input = readText("Appuyez sur entrer pour continuer");
  } while (input != "");
}

int flipACoin() {
  var r = new Random();
  return r.nextInt(2);
}

// int requestUserPick(String msg, int minimum, int maximum) {
//         int selectedValue;
//         do {
//             print(msg);
//             print("Entrez une valeur comprise entre {minimum} et {maximum} : ");
//             selectedValue = Utilisateur.saisirEntier();
//         } while (selectedValue < minimum || selectedValue > maximum);

//         return selectedValue;
//     }
