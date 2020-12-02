import 'NE_PAS_TOUCHER/user_input.dart';
import 'bot.class.dart';
import 'dart:math';
import 'player.class.dart';
import 'character.class.dart';
import 'Console_manager.dart';

void main() {
  //DEBUT de votre programme

  final p1 = Player(askNickName());
  final b1 = Bot();
  print(
      "Bienvenue ${p1.nickname} ! Préparez vous à participer à une quête épique ! ");

  // Qui commence
  var currentChara = flipACoin();
  do {
    var dicesValue;
    p1.chooseNextMove(b1, dicesValue, p1);

    if (currentChara == 1) {
      fight(b1, dicesValue, p1);
      currentChara = 2;
    } else {
      fight_bot(b1, dicesValue, p1);
      currentChara = 1;
    }
  } while (b1.lifePoints > 0 && p1.lifePoints > 0);
  if (b1.lifePoints <= 0) {
    print("Vous avez gagné !");
  } else if (p1.lifePoints <= 0) {
    print("GAME OVER !");
  }
  //FIN de votre programme
}

void fight(b1, var dicesValue, p1) {
  awaitPlayer();
  dicesValue = dices(name: p1.nickname);
  dealDamages(b1, dicesValue);
}

void fight_bot(b1, var dicesValue, p1) {
  dicesValue = dices(name: b1.nickname);
  dealDamages(p1, dicesValue);
}
