import 'dart:wasm';

import 'NE_PAS_TOUCHER/user_input.dart';
import 'app.dart';
import 'character.class.dart';
import 'dart:math';

class Player extends Character {
  Player(String nickname) : super() {
    this.nickname = nickname;
    this.strenght = strenght;
    this.lifePoints = lifePoints;
    this.score = score;
  }
  void chooseNextMove(b1, dicesValue, p1) {
    if (lifePoints > 0) {
      int userChoice;
      if (lifePoints < 50) {
        do {
          userChoice = readInt(
              "Tapez 1 pour attaquer ou 2 pour vous soigner à la place");
        } while (userChoice < 1 || userChoice > 2);
      }
      switch (userChoice) {
        case 1:
          fight_bot(b1, dicesValue, p1);
          break;
        case 2:
          lifePoints = rest(lifePoints);
          print(nickname + " ta santé est à ${lifePoints} pv");
          break;
        default:
          break;
      }
    }
  }

  int rest(int soin) {
    print("Vous avez 1 chance sur 2 pour vous soigner");
    var r = new Random();
    var dicesValue = r.nextInt(2);
    print("Vous avez obtenu $dicesValue");
    if (dicesValue == 1) {
      soin = (this.lifePoints * 2) - 20;
    } else {
      print("Malheureusement vous n'avez pas pu vous soigner");
    }
    return soin;
  }
}

// {} = Facultatif
