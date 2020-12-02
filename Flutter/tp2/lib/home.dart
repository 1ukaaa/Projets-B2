import 'dart:async';

import 'package:flutter/material.dart';
import 'package:tp2/Model/game_result.dart';

class Home extends StatefulWidget {
  @override
  _HomeState createState() => _HomeState();
}

class _HomeState extends State<Home> {
  var _clickCount = 0;
  var _isCounting = false;
  var _record;
  var _bad = false;
  var _name = "";
  final List<GameResult> _resulList = [];

  _startCounting() {
    setState(() {
      _clickCount = 0;
      _isCounting = true;
      Timer(Duration(seconds: 3), _stopGame);
    });
  }

  _stopGame() {
    setState(() {
      _isCounting = false;
      final result = GameResult(_name, _clickCount);
      _resulList.add(result);
      if (_record == null || _clickCount > _record) {
        _record = _clickCount;
        _bad = false;
      } else {
        _bad = true;
      }
    });
  }

  _clickButtonTouched() {
    setState(() {
      _clickCount++;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text("Cliquer"),
      ),
      body: SafeArea(
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.stretch,
          children: [
            Row(),
            TextField(
              decoration: InputDecoration(
                  helperText: "Entrez votre prénom", hintText: "Prénom"),
              autocorrect: false,
              textCapitalization: TextCapitalization.words,
              autofillHints: [AutofillHints.givenName],
              keyboardType: TextInputType.name,
              onChanged: (value) {
                setState(() {
                  _name = value;
                });
              },
            ),
            if (_record != null) Text("Record détenu par $_name : $_record"),
            Text("Nombre de clics : $_clickCount"),
            if (_bad == true) Text("Tu n'as pas réussi à battre le record"),
            if (_isCounting)
              IconButton(
                  icon: Icon(Icons.plus_one), onPressed: _clickButtonTouched),
            Spacer(),
            if (_isCounting == false)
              ElevatedButton(
                  onPressed: _startCounting,
                  child: Text("Commencer à compter")),
          ],
        ),
      ),
    );
  }
}
