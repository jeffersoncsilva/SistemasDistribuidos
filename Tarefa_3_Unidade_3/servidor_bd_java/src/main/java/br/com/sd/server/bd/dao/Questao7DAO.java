package br.com.sd.server.bd.dao;

import br.com.sd.server.bd.infra.ConnectionFactory;
import br.com.sd.server.bd.model.Questao6;
import br.com.sd.server.bd.model.Questao7;
import com.google.gson.Gson;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import java.util.Optional;

public class Questao7DAO implements IQuestaoDAO<Questao7> {
    @Override
    public Questao7 save(Questao7 q) {
        return null;
    }

    @Override
    public Questao7 update(Questao7 q) {
        return null;
    }

    @Override
    public List<Questao7> findAll() {
        String sql = "select * from questao07";
        List<Questao7> q = new ArrayList<>();
        try{
            try(Connection con = ConnectionFactory.getConnection()){
                PreparedStatement p = con.prepareStatement(sql);
                ResultSet rs = p.executeQuery();
                while(rs.next()){
                    // Long id, int idade, int tempo_trabalh
                    Long id = rs.getLong("id");
                    int idade = rs.getInt("idade");
                    int tempo = rs.getInt("tempo_trabalho");
                    q.add(new Questao7(id, idade, tempo));
                }
            }
        }catch (SQLException ex){
            throw new RuntimeException(ex);
        }
        return q;
    }

    @Override
    public Optional<Questao7> findById(Long id) {
        return Optional.empty();
    }

    @Override
    public String findAllJsonFormat() {
        List<Questao7> all = findAll();
        Gson gson = new Gson();
        String json = gson.toJson(all);
        return json;
    }

    @Override
    public String findByIdJsonFormat(Long id) {
        return null;
    }
}
