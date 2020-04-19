using System.Collections.Generic;
using UnityEngine;
using System;


    public class CardData : MonoBehaviour
    {

        //a string
        public string[] cardNameList;
        //the dictionary allows for a 2D Array with both strings and int
        //a tuple was used to store multiple int values as they're more flexible to used rather than int[]s. 
        //we were also planning on incoporating "special moves" (like hearthstone's taunt) that would be added in 
        //the tuple as a Tuple<int, int, int, string> for easier identification
        public static IDictionary<string, Tuple<int, int, int>> masterList = new Dictionary<string, Tuple<int, int, int>>();
        
        //an easy to call method that allows for card to be added easily. Used to call and identify cards, rather than the master list because
        //the dictionary stores stats we can call on where the array allows us to copy to store deck, hand and field arrays. bc and array is simpler. 
        public void createCard(string name) {
        Array.Resize(ref cardNameList, cardNameList.Length + 1);
        cardNameList[cardNameList.GetUpperBound(0)] = name;
        string cardName = name;
        }

        //adds stats to the card
        public void setCardDefinition(string name, int cost, int attack, int health) {
            //checks to see if they are in the cardNameList array
            if (Array.Exists(cardNameList, element => element == name)) {
                if (masterList.ContainsKey(name)) Debug.Log(name + " is Already in the List :(");
                else {
                    Tuple<int, int, int> stats = new Tuple<int, int, int>(cost, attack, health);
                    masterList.Add(name, stats);
                }
            }
        }

        //returns the card stats
        public string getCardDefinition(string name) {
        Tuple<int, int, int>tuple = new Tuple<int, int, int>(masterList[name].Item1, masterList[name].Item2, masterList[name].Item3);
        string definition = tuple.ToString();
            return definition;
        }    

        //you can easily tweak and call stats for game logic using the getters and setters below. 


        public void setCost(string name, int cost) {
            if (masterList.ContainsKey(name)) {
            Tuple<int, int, int>tuple1 = masterList[name];
            Tuple<int, int, int>tuple2 = new Tuple<int, int, int>(cost, tuple1.Item2, tuple1.Item3);
            masterList[name] = (tuple2);
            Debug.Log(name + " " + masterList[name]);
            } else {
                Debug.Log(name + " is not in the MasterList. Please Insert It using the setCardDefinition Method");
            }
        }

        public int getCost(string name) {
            return masterList[name].Item1;
        }

        public void setAttack(string name, int attack) {
            if (masterList.ContainsKey(name)) {
            Tuple<int, int, int>tuple1 = masterList[name];
            Tuple<int, int, int>tuple2 = new Tuple<int, int, int>(tuple1.Item1, attack, tuple1.Item3);
            masterList[name] = (tuple2);
            Debug.Log(name + " " + masterList[name]);
            } else {
                
            }
        }

        public int getAttack(string name) {
            return masterList[name].Item2;
        }

        public void setHealth(string name, int health) {
            if (masterList.ContainsKey(name)) {
            Tuple<int, int, int>tuple1 = masterList[name];
            Tuple<int, int, int>tuple2 = new Tuple<int, int, int>(tuple1.Item1, tuple1.Item2, health);
            masterList[name] = (tuple2);
            Debug.Log(name + " " + masterList[name]);
            } else {
                
            }
        }

        public int getHealth(string name) {
            return masterList[name].Item3;
        }

    }

