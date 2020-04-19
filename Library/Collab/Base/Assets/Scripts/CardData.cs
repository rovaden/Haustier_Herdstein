using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


    public class CardData : MonoBehaviour
    {

        public static string[] cardNameList = { };
        public static IDictionary<string, Tuple<int, int, int>> masterList = new Dictionary<string, Tuple<int, int, int>>();

        public void createCard(string name)
        {
        Array.Resize(ref cardNameList, cardNameList.Length + 1);
        cardNameList[cardNameList.GetUpperBound(0)] = name;
        string cardName = name;
        }

        public void setCardDefinition(string name, int cost, int attack, int health)
        {
            if (Array.Exists(cardNameList, element => element == name))
            {
                if (masterList.ContainsKey(name)) { }
                else
                {
                    Tuple<int, int, int> stats = new Tuple<int, int, int>(cost, attack, health);
                    masterList.Add(name, stats);
                }
        }
        }

        public string getCardDefinition(string name)
        {
        Tuple<int, int, int>tuple = new Tuple<int, int, int>(masterList[name].Item1, masterList[name].Item2, masterList[name].Item3);
        string definition = tuple.ToString();
            return definition;
        }    

        public void setCost(string name, int cost)
        {
            if (masterList.ContainsKey(name)) {
            Tuple<int, int, int>tuple1 = masterList[name];
            Tuple<int, int, int>tuple2 = new Tuple<int, int, int>(cost, tuple1.Item2, tuple1.Item3);
            masterList[name] = (tuple2);
            Debug.Log(name + " " + masterList[name]);
            } else
            {
                
            }
        }
        public void getCost()
        {

        }

        public void setAttack() { }
    
        public void setHealth() { }

    }

