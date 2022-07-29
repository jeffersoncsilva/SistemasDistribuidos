package br.com.sd.server.bd.infra;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class ConnectionFactory {

    private ConnectionFactory() { }

    public static Connection getConnection(){
        try {
            return DriverManager.getConnection("jdbc:mysql://localhost:3306/lista_03", "root", "2486");
        } catch (SQLException ex){
            throw new RuntimeException(ex);
        }
    }
}
