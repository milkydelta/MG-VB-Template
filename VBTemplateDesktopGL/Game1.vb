Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework.Input


Namespace VBConsole
	Class Game1
		Inherits Game
		Private _graphics As GraphicsDeviceManager
		Private _spriteBatch As SpriteBatch

		Public Sub New()
			_graphics = new GraphicsDeviceManager(Me)
			Content.RootDirectory = "Content"
			IsMouseVisible = True
		End Sub

		Overrides Protected Sub Initialize()
			
			MyBase.Initialize()
		End Sub
		
		Overrides Protected Sub LoadContent()
			_spriteBatch = new SpriteBatch(GraphicsDevice)


		End Sub

		Overrides Protected Sub Update(gameTime As GameTime)
			If (Gamepad.GetState(PlayerIndex.One).Buttons.Back = ButtonState.Pressed or Keyboard.GetState().IsKeyDown(Keys.Escape)) Then
				Environment.Exit(0)
			End If
			
			MyBase.Update(gameTime)
			
		End Sub

		Overrides Protected Sub Draw(gameTime as GameTime)
			GraphicsDevice.Clear(Color.CornflowerBlue)


			MyBase.Draw(gameTime)
			
		End Sub
	End Class
End Namespace
