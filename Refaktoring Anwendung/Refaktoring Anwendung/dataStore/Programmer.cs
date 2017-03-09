/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

using System;

namespace soft.thein.de.refaktoring.datastore
{

    /**
     *
     * @author root
     */

    public class Programmer
    {

        private String name;
        private String lastname;
        private int score;
        private int skilllevel;
        private int mood;

        public Programmer(String name, String lastname, int score, int skilllevel, int mood)
        {
            this.name = name;
            this.lastname = lastname;
            this.score = score;
            this.skilllevel = skilllevel;
            this.mood = mood;
        }

        /**
     * @return the name
     */

        public String getName()
        {
            return name;
        }

        /**
     * @param name the name to set
     */

        public void setName(String name)
        {
            this.name = name;
        }

        /**
     * @return the lastname
     */

        public String getLastname()
        {
            return lastname;
        }

        /**
     * @param lastname the lastname to set
     */

        public void setLastname(String lastname)
        {
            this.lastname = lastname;
        }

        /**
     * @return the score
     */

        public int getScore()
        {
            return score;
        }

        /**
     * @param score the score to set
     */

        public void setScore(int score)
        {
            this.score = score;
        }

        /**
     * @return the skilllevel
     */

        public int getSkilllevel()
        {
            return skilllevel;
        }

        /**
     * @param skilllevel the skilllevel to set
     */

        public void setSkilllevel(int skilllevel)
        {
            this.skilllevel = skilllevel;
        }

        /**
     * @return the mood
     */

        public int getMood()
        {
            return mood;
        }

        /**
     * @param mood the mood to set
     */

        public void setMood(int mood)
        {
            this.mood = mood;
        }

    }
}