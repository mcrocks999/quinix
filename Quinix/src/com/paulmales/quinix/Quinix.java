package com.paulmales.quinix;

import java.awt.EventQueue;

import javax.swing.ImageIcon;
import javax.swing.JFrame;
import java.awt.Color;
import java.awt.Dimension;

import javax.swing.JPanel;
import java.awt.BorderLayout;
import javax.swing.JLabel;
import java.awt.FlowLayout;
import javax.swing.JButton;
import javax.swing.border.LineBorder;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;

@SuppressWarnings("serial")
public class Quinix extends JFrame {

	JButton btnStart = new JButton(new ImageIcon("QuinixData\\startBtn.png"));
	StartMenu frame = new StartMenu();
	
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
		
		JPanel viewPort = new JPanel();
		viewPort.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				frame.setVisible(false);
			}
		});
		viewPort.setBackground(new Color(0, 89, 157));
		getContentPane().add(viewPort, BorderLayout.CENTER);
		viewPort.setLayout(new BorderLayout(0, 0));
		
		JLabel background = new JLabel(new ImageIcon("QuinixData\\background.jpg"));
		viewPort.add(background, BorderLayout.CENTER);
		
		JPanel taskbar = new JPanel();
		taskbar.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent arg0) {
				frame.setVisible(false);
			}
		});
		taskbar.setBackground(new Color(34, 157, 252));
		viewPort.add(taskbar, BorderLayout.SOUTH);
		taskbar.setLayout(new FlowLayout(FlowLayout.LEFT, 5, 5));
		taskbar.setBorder(new LineBorder(new Color(0, 70, 123), 5, true));
		btnStart.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if (frame.isVisible()) {
					frame.setVisible(false);
				}else{
					frame.setVisible(true);
					frame.setLocation(0, viewPort.getHeight() - taskbar.getHeight() - frame.getHeight());
				}
			}
		});
		
		btnStart.setMaximumSize(new Dimension(50, 50));
		btnStart.setPreferredSize(new Dimension(50, 50));
		btnStart.setMinimumSize(new Dimension(50, 50));
		btnStart.setBorderPainted(false);
		btnStart.setContentAreaFilled(false);
		taskbar.add(btnStart);
	}
	
}