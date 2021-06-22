using System;
using System.Collections.Generic;
using System.Text;

namespace functional
{
    public class ListenerTest
    {

        public static void Main(String[] args)
        {
            JButton testButton = new JButton("Test Button");
            testButton.addActionListener(new ActionListener());
            testButton.addActionListener(e, -, Greater, System.out.println("Click Detected by Lambda Listner"));
            //  Swing stuff
            JFrame frame = new JFrame("Listener Test");
            frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
            frame.add(testButton, BorderLayout.CENTER);
            frame.pack();
            frame.setVisible(true);
        }
    }
}
