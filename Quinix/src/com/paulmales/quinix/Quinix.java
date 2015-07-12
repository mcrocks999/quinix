package com.paulmales.quinix;

import java.awt.EventQueue;

import javax.swing.ImageIcon;
import javax.swing.JFrame;
import java.awt.Color;
import javax.swing.JPanel;
import java.awt.BorderLayout;
import javax.swing.JLabel;
import java.awt.FlowLayout;
import javax.swing.JButton;
import javax.swing.border.LineBorder;

@SuppressWarnings("serial")
public class Quinix extends JFrame {

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Quinix frame = new Quinix();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	public Quinix() {
		setBackground(new Color(0, 89, 157));
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(0, 0, 450, 300);
		setUndecorated(true);
		setExtendedState(JFrame.MAXIMIZED_BOTH);
		
		JPanel panel = new JPanel();
		panel.setBackground(new Color(0, 89, 157));
		getContentPane().add(panel, BorderLayout.CENTER);
		panel.setLayout(new BorderLayout(0, 0));
		
		JLabel background = new JLabel(new ImageIcon("QuinixData\\background.jpg"));
		panel.add(background, BorderLayout.CENTER);
		
		JPanel panel_1 = new JPanel();
		panel_1.setBackground(new Color(34, 157, 252));
		panel.add(panel_1, BorderLayout.SOUTH);
		panel_1.setLayout(new FlowLayout(FlowLayout.LEFT, 5, 5));
		panel_1.setBorder(new LineBorder(new Color(0, 70, 123), 5, true));
		
		JButton btnStart = new JButton(new ImageIcon("C:\\Users\\Rains\\Documents\\GitHub\\quinix\\Quinix\\QuinixData\\startBtn.png"));
		btnStart.setBorderPainted(false);
		btnStart.setContentAreaFilled(false);
		panel_1.add(btnStart);
	}
	
}