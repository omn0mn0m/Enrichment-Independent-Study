using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace TopDownShooter
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public class Player : Microsoft.Xna.Framework.GameComponent
    {
        public Player(Game game)
            : base(game)
        {
            // TODO: Construct any child components here
        }

        /// <summary>
        /// Allows the game component to perform any initialization it needs to before starting
        /// to run.  This is where it can query for any required services and load content.
        /// </summary> 

        // Declare movement/utility variables
        protected int moveSpeed; //Units moved per cycle of game
        protected int pickupRange; //Units from which player can pick up items
        protected int interactRange; //Units from which player can "use" objects"

        // Declare analytics variables
        protected int healthPoints; //health pool
        protected int physResistance; //Resistance to physical (Melee + bullet) damage
        protected int meleeResistance; //Resistance to melee only
        protected int bulletResistance; //Resistance to bullets only
        protected int fireResistance; //Resistance to fire damage
        protected int elecResistance; //Resistance to electrical damage
        protected int iceResistance; //Resistance to ice damage
        protected int elemResistance; //Resistance to all elemental damage

        public override void Initialize()
        {
            // TODO: Add your initialization code here
            base.Initialize();
        }

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            // TODO: Add your update code here
            
            this.detectInput();
            base.Update(gameTime);
        }

        private void detectInput()
        {
            //TODO: Add input detection
        }
    }
}
