package br.com.sd.server.bd.dao;

import br.com.sd.server.bd.infra.ConnectionFactory;
import br.com.sd.server.bd.model.Questao4;
import br.com.sd.server.bd.model.Questao5;
import br.com.sd.server.bd.model.Questao6;
import com.google.gson.Gson;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import java.util.Optional;

public class Questao6DAO implements IQuestaoDAO<Questao6>{

    @Override
    public Questao6 save(Questao6 q) {
        return null;
    }

    @Override
    public Questao6 update(Questao6 q) {
        return null;
    }

    @Override
    public List<Questao6> findAll() {
        String sql = "select * from questao06";
        List<Questao6> q = new ArrayList<>();
        try{
            try(Connection con = ConnectionFactory.getConnection()){
                PreparedStatement p = con.prepareStatement(sql);
                ResultSet rs = p.executeQuery();
                while(rs.next()){
                    // Long id, String nome, String nivel, Double salario, int dependentes
                    Long id = rs.getLong("id");
                    String nome = rs.getString("nome");
                    String nivel = rs.getString("nivel");
                    double salario = rs.getDouble("salario");
                    int dependentes = rs.getInt("dependentes");
                    q.add(new Questao6(id, nome, nivel, salario, dependentes));
                }
            }
        }catch (SQLException ex){
            throw new RuntimeException(ex);
        }
        return q;
    }

    @Override
    public Optional<Questao6> findById(Long id) {
        return Optional.empty();
    }

    @Override
    public String findAllJsonFormat() {
        List<Questao6> all = findAll();
        Gson gson = new Gson();
        String json = gson.toJson(all);
        return json;
    }

    @Override
    public String findByIdJsonFormat(Long id) {
        return null;
    }
}
