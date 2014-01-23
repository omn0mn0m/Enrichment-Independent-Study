/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package creatures;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import objects.*;
import skills.*;

/**
 *
 * @author Pat Walls
 */
public abstract class Player {
    
    // Ding Variable
    protected int level;
    
    // HP and Mana variables
    protected int maxHP;
    protected int maxMana;
    protected int hp;
    protected int mana;
    protected int hpRegen;
    protected int manaRegen;

    // Skill point variables
    protected int fortitude;
    protected int defense;
    protected int strength;
    protected int dexterity;
    protected int swiftness;
    protected int luck;
    protected int intellect;
    protected int wisdom;
    protected int sight;
    
    // Attack damage variables
    protected int attackDamage;
    protected int attackSpeed;
    protected int rangedDamage;
    protected int spellDamage;
    
    // Create 30 slot inventory, 10 Slot equip inventory, infinate spell inventory, and infinate ability inventory
    Item[] inventory = new Item[30];
    Item[] equipSlots = new Item[10];
    List<Spell> spellsLearned = new ArrayList();
    List<Ability> abilitiesLearned = new ArrayList();
    
    public String getPlayerInput()
    {
        Scanner playerInput = new Scanner(System.in);
        String input = playerInput.next();        
        return input;
    }
    
    // Method to set HP
    public void setHP(int hpChange)
    {
        // Set negative values to reduce hp of object
        hp += hpChange;
    }
    
    // Method to set mana
    public void setMana(int manaChange)
    {
        // Set negative values to reduce mana of object
        mana += manaChange;
    }         
}