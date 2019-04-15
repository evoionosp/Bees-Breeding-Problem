/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapp;

import java.util.Scanner;

/**
 *
 * @author shubh
 */
public class Solution{
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        while(true){ int a = scan.nextInt();
        int b = scan.nextInt();
        if(a==0&&b==0)
            break;
        Point p = new Point(0,0);
        p = cal(a);
        Point p1 = new Point(p.x,p.y);
        p = cal(b);
        Point p2 = new Point(p.x,p.y);
        int x = p1.x-p2.x;
        int y = p1.y-p2.y;
        int ans;
        if(x*y<=0)
            ans = Math.max(Math.abs(x), Math.abs(y));
        else
            ans = Math.abs(x+y);
        System.out.printf("The distance between cells %d and %d is %d.",a,b,ans);
        System.out.println();
        }
    }
    public static Point cal(int a) {
        if(a == 1){
            return new Point(0,0);
        }
        int x;
        int y;
        int n = 0;
        while(3*(n-1)*n+1< a)
            n++;
        n--;
        a -= 3*(n-1)*n+1;
        if(a<=n){
            x = n;
            y = -a;
        }else if(a>n&&a<=2*n){
            x = 2*n-a;
            y = -n;
        }else if(a>2*n&&a<=3*n){
            x = 2*n-a;
            y = -n-x;
        }else if(a>3*n&&a<=4*n){
            x = -n;
            y = a-3*n;
        }else if(a>4*n&&a<=5*n){
            x = a-5*n;
            y = n;
        }else{
            x = a-5*n;
            y = n-x;
        }
        Point p = new Point(x,y);
        return p;
    }

    public static class Point{
    int x;
    int y;
        public Point(int x, int y) {
            super();
            this.x = x; this.y = y;
        }
    }
}

