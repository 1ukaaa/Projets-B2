import 'character.class.dart';

class Bot extends Character {
  Bot({String nickname = "Bot", int strenght = 1, int lifePoints = 100}) {
    this.nickname = nickname;
    this.strenght = strenght;
    this.lifePoints = lifePoints;
  }
}
