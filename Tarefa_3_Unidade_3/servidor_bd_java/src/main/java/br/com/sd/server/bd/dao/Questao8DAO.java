package br.com.sd.server.bd.dao;

import br.com.sd.server.bd.infra.ConnectionFactory;
import br.com.sd.server.bd.model.Questao6;
import br.com.sd.server.bd.model.Questao7;
import br.com.sd.server.bd.model.Questao8;
import com.google.gson.Gson;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import java.util.Optional;

public class Questao8DAO implements IQuestaoDAO<Questao8> {
    @Override
    public Questao8 save(Questao8 q) {
        return null;
    }

    @Override
    public Questao8 update(Questao8 q) {
        return null;
    }

    @Override
    public List<Questao8> findAll() {
        String sql = "select * from questao08";
        List<Questao8> q = new ArrayList<>();
        try{
            try(Connection con = ConnectionFactory.getConnection()){
                PreparedStatement p = con.prepareStatement(sql);
                ResultSet rs = p.executeQuery();
                while(rs.next()){
                    // Long id, Double salario_medio
                    Long id = rs.getLong("id");
                    double salario = rs.getDouble("salario");
                    q.add(new Questao8(id,salario));
                }
            }
        }catch (SQLException ex){
            throw new RuntimeException(ex);
        }
        return q;
    }

    @Override
    public Optional<Questao8> findById(Long id) {
        return Optional.empty();
    }

    @Override
    public String findAllJsonFormat() {
        List<Questao8> all = findAll();
        Gson gson = new Gson();
        String json = gson.toJson(all);
        return json;
    }

    @Override
    public String findByIdJsonFormat(Long id) {
        return null;
    }
}
