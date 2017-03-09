/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

using System;

namespace soft.thein.de.refaktoring.datastore
{


    public class ProgrammerBuilder
    {
        private String name = "Hans";
        private String lastname = "Peter";
        private int score = 0;
        private int skilllevel = 10;
        private int mood;

        public ProgrammerBuilder()
        {
        }

        public ProgrammerBuilder setName(String name)
        {
            this.name = name;
            return this;
        }

        public ProgrammerBuilder setLastname(String lastname)
        {
            this.lastname = lastname;
            return this;
        }

        public ProgrammerBuilder setScore(int score)
        {
            this.score = score;
            return this;
        }

        public ProgrammerBuilder setSkilllevel(int skilllevel)
        {
            this.skilllevel = skilllevel;
            return this;
        }

        public ProgrammerBuilder setMood(int mood)
        {
            this.mood = mood;
            return this;
        }

        public Programmer createProgrammer()
        {
            return new Programmer(name, lastname, score, skilllevel, mood);
        }

    }
}