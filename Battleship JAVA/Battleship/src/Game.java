import javax.swing.*;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;


public class Game implements KeyListener {
 
    public static void main(String[] args) {
        Game game = new Game();
    }

    private GamePanel gamePanel;

    public Game() {
        // Choose the AI Difficulty
        String[] options = new String[] {"Fácil", "Medio", "Díficil"};
        String message = "Fácil hará movimientos completamente al azar.\nMedio se centrará en las áreas donde encuentra barcos,"
                + "\ny Díficil tomará decisiones más inteligentes sobre Medio.";
        int difficultyChoice = JOptionPane.showOptionDialog(null, message,
                "Elige una dificultad de IA",
                JOptionPane.DEFAULT_OPTION, JOptionPane.PLAIN_MESSAGE,
                null, options, options[0]);

        JFrame frame = new JFrame("BATTLESHIP");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setResizable(false);

        gamePanel = new GamePanel(difficultyChoice);
        frame.getContentPane().add(gamePanel);

        frame.addKeyListener(this);
        frame.pack();
        frame.setVisible(true);
    }

    public void keyPressed(KeyEvent e) {
        gamePanel.handleInput(e.getKeyCode());
    }

    public void keyTyped(KeyEvent e) {}

    public void keyReleased(KeyEvent e) {}
}
