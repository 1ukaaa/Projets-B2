import 'dart:math';

class Character {
  String _nickname;
  int _strenght = 1;
  int _lifePoints = 100;
  int _score;

  String get nickname => _nickname;
  set nickname(String value) {
    _nickname = value;
  }

  int get strenght => _strenght;
  set strenght(int value) {
    if (value >= 1 && value <= 10) {
      _strenght = value;
    }
  }

  int get lifePoints => _lifePoints;
  set lifePoints(int value) {
    if (value >= 0 && value <= 100) {
      _lifePoints = value;
    }
  }

  int get score => _score;
  set score(int value) {
    _score = value;
  }
}

int dices({String name = ""}) {
  var r = new Random();
  var dicesValue = (r.nextInt(6) + 1) + (r.nextInt(1 + 7));
  print("$name, vous avez obtenu $dicesValue au dés.");
  return dicesValue;
}

void dealDamages(Character character, int dicesValue) {
  if (character.lifePoints > 0 && character.lifePoints > dicesValue) {
    character.lifePoints -= dicesValue;
    print("Il reste ${character.lifePoints} pv à ${character.nickname}.");
  } else if (character.lifePoints <= dicesValue) {
    print("${character.nickname} est mort ! ");
    character.lifePoints = 0;
  }
}
