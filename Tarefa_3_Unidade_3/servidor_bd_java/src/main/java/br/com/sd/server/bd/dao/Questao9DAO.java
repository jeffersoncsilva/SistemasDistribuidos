package br.com.sd.server.bd.dao;

import br.com.sd.server.bd.infra.ConnectionFactory;
import br.com.sd.server.bd.model.Cargo;
import br.com.sd.server.bd.model.Questao1;
import br.com.sd.server.bd.model.Questao8;
import br.com.sd.server.bd.model.Questao9;
import com.google.gson.Gson;

import java.sql.*;
import java.util.ArrayList;
import java.util.List;
import java.util.Optional;
import java.util.concurrent.atomic.AtomicReference;

public class Questao9DAO implements IQuestaoDAO<Questao9> {
    @Override
    public Questao9 save(Questao9 q) {
        try {
            try (Connection connection = ConnectionFactory.getConnection()) {
                String sql = "insert into questao09 (valor, naipe) values (?, ?)";
                PreparedStatement p = connection.prepareStatement(sql, Statement.RETURN_GENERATED_KEYS);
                p.setString(1, q.getValor());
                p.setString(2, q.getNaipe());
                p.executeUpdate();
            }
        }catch (SQLException ex){
            throw new RuntimeException(ex);
        }
        return q;
    }

    @Override
    public Questao9 update(Questao9 q) {
        return null;
    }

    @Override
    public List<Questao9> findAll() {
        String sql = "select * from questao09";
        List<Questao9> q = new ArrayList<>();
        try{
            try(Connection con = ConnectionFactory.getConnection()){
                PreparedStatement p = con.prepareStatement(sql);
                ResultSet rs = p.executeQuery();
                while(rs.next()){
                    // Long id, String valor, String naipe
                    Long id = rs.getLong("id");
                    String valor = rs.getString("valor");
                    String naipe = rs.getString("naipe");
                    q.add(new Questao9(id,valor, naipe));
                }
            }
        }catch (SQLException ex){
            throw new RuntimeException(ex);
        }
        return q;
    }

    @Override
    public Optional<Questao9> findById(Long id) {
        String sql = "select * from questao09 where id = ?";
        Questao9 q = null;
        try{
            try(Connection con = ConnectionFactory.getConnection()){
                PreparedStatement p = con.prepareStatement(sql);
                p.setLong(1, id);
                ResultSet rs = p.executeQuery();
                if(rs.next()){
                    Long i = rs.getLong("id");
                    String valor = rs.getString("valor");
                    String naipe = rs.getString("naipe");
                    q = new Questao9(valor, naipe);
                }
            }
        }catch (SQLException ex){
            throw new RuntimeException(ex);
        }
        return Optional.ofNullable(q);
    }

    @Override
    public String findAllJsonFormat() {
        List<Questao9> all = findAll();
        Gson gson = new Gson();
        String json = gson.toJson(all);
        return json;
    }

    @Override
    public String findByIdJsonFormat(Long id) {
        AtomicReference<String> response = new AtomicReference<>("Não foi possivel econtrar nada com o ID especificado.");
        Optional<Questao9> q = findById(id);
        q.ifPresent(a -> {
            List<Questao9> res = new ArrayList<>();
            res.add(a);
            Gson g = new Gson();
            response.set(g.toJson(res));
        });
        return response.get();
    }
}
