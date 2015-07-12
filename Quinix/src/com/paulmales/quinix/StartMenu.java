package com.paulmales.quinix;

import java.awt.BorderLayout;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import java.awt.Color;
import javax.swing.JLabel;
import javax.swing.SwingConstants;
import java.awt.Font;
import javax.swing.JList;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.border.LineBorder;

@SuppressWarnings("serial")
public class StartMenu extends JFrame {

	private JPanel contentPane;

	@SuppressWarnings("rawtypes")
	public StartMenu() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 600);
		setUndecorated(true);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(0, 0, 0, 0));
		contentPane.setLayout(new BorderLayout(0, 0));
		setContentPane(contentPane);
		
		JPanel viewPort = new JPanel();
		viewPort.setBorder(new LineBorder(new Color(0, 0, 0), 1, true));
		viewPort.setBackground(new Color(0, 122, 215));
		contentPane.add(viewPort, BorderLayout.CENTER);
		viewPort.setLayout(null);
		
		JLabel lblQuinixV = new JLabel("Quinix v1.0.0");
		lblQuinixV.setForeground(Color.WHITE);
		lblQuinixV.setFont(new Font("Trebuchet MS", Font.BOLD, 24));
		lblQuinixV.setHorizontalAlignment(SwingConstants.CENTER);
		lblQuinixV.setBounds(10, 10, 430, 50);
		viewPort.add(lblQuinixV);
		
		JPanel programListContainer = new JPanel();
		programListContainer.setBounds(20, 70, 200, 410);
		viewPort.add(programListContainer);
		programListContainer.setLayout(new BorderLayout(0, 0));
		
		JList programList = new JList();
		programList.setBackground(new Color(8, 148, 255));
		programListContainer.add(programList);
		
		JButton btnShutdown = new JButton("Shutdown");
		btnShutdown.setForeground(Color.WHITE);
		btnShutdown.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				System.exit(0);
			}
		});
		btnShutdown.setFont(new Font("Trebuchet MS", Font.BOLD, 24));
		btnShutdown.setBounds(20, 549, 420, 40);
		btnShutdown.setBackground(new Color(34, 157, 252));
		viewPort.add(btnShutdown);
		
		JButton btnSettings = new JButton("Settings");
		btnSettings.setForeground(Color.WHITE);
		btnSettings.setFont(new Font("Trebuchet MS", Font.BOLD, 24));
		btnSettings.setBounds(20, 499, 420, 40);
		btnSettings.setBackground(new Color(34, 157, 252));
		viewPort.add(btnSettings);
		
		JButton btnFileBrowser = new JButton("File Browser");
		btnFileBrowser.setForeground(Color.WHITE);
		btnFileBrowser.setFont(new Font("Trebuchet MS", Font.BOLD, 16));
		btnFileBrowser.setBounds(290, 71, 150, 40);
		btnFileBrowser.setBackground(new Color(0, 70, 123));
		viewPort.add(btnFileBrowser);
		
		JButton btnInternet = new JButton("Internet");
		btnInternet.setForeground(Color.WHITE);
		btnInternet.setFont(new Font("Trebuchet MS", Font.BOLD, 16));
		btnInternet.setBounds(290, 122, 150, 40);
		btnInternet.setBackground(new Color(0, 89, 157));
		viewPort.add(btnInternet);
		
		JButton btnVideoPlayer = new JButton("Video Player");
		btnVideoPlayer.setForeground(Color.WHITE);
		btnVideoPlayer.setFont(new Font("Trebuchet MS", Font.BOLD, 16));
		btnVideoPlayer.setBackground(new Color(0, 70, 123));
		btnVideoPlayer.setBounds(290, 173, 150, 40);
		viewPort.add(btnVideoPlayer);
		
		JButton btnAudioPlayer = new JButton("Audio Player");
		btnAudioPlayer.setForeground(Color.WHITE);
		btnAudioPlayer.setFont(new Font("Trebuchet MS", Font.BOLD, 16));
		btnAudioPlayer.setBackground(new Color(0, 89, 157));
		btnAudioPlayer.setBounds(290, 225, 150, 40);
		viewPort.add(btnAudioPlayer);
		
		JLabel iconFileBrowser = new JLabel(new ImageIcon("QuinixData\\file-manager.png"));
		iconFileBrowser.setBounds(230, 70, 40, 40);
		viewPort.add(iconFileBrowser);
		
		JLabel iconInternet = new JLabel(new ImageIcon("QuinixData\\internet.png"));
		iconInternet.setBounds(230, 122, 40, 40);
		viewPort.add(iconInternet);
		
		JLabel iconVideoPlayer = new JLabel(new ImageIcon("QuinixData\\video-player.jpg"));
		iconVideoPlayer.setBounds(230, 173, 40, 40);
		viewPort.add(iconVideoPlayer);
		
		JLabel iconAudioPlayer = new JLabel(new ImageIcon("QuinixData\\audio-player.png"));
		iconAudioPlayer.setBounds(230, 225, 40, 40);
		viewPort.add(iconAudioPlayer);
	}
}