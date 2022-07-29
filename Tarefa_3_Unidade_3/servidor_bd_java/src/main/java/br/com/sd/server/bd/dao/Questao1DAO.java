package br.com.sd.server.bd.dao;

import br.com.sd.server.bd.infra.ConnectionFactory;
import br.com.sd.server.bd.model.Cargo;
import br.com.sd.server.bd.model.Questao1;
import com.google.gson.Gson;

import java.sql.*;
import java.util.ArrayList;
import java.util.List;
import java.util.Optional;
import java.util.concurrent.atomic.AtomicReference;

public class Questao1DAO implements IQuestaoDAO<Questao1> {

    @Override
    public Questao1 save(Questao1 q) {
        try {
            try (Connection connection = ConnectionFactory.getConnection()) {
                String sql = "insert into questao01 (nome, cargo, salario) values (?, ?, ?)";
                PreparedStatement p = connection.prepareStatement(sql, Statement.RETURN_GENERATED_KEYS);
                p.setString(1, q.getNome());
                p.setString(2, q.getCargo().toString());
                p.setDouble(3, q.getSalario());
                p.executeUpdate();
                ResultSet set = p.getGeneratedKeys();
                set.next();
                q.setId(set.getLong("id"));
            }
        }catch (SQLException ex){
            throw new RuntimeException(ex);
        }
        return q;
    }

    @Override
    public Questao1 update(Questao1 q) {
        return null;
    }

    @Override
    public List<Questao1> findAll() {
        String sql = "select * from questao01";
        List<Questao1> q = new ArrayList<>();
        try{
            try(Connection con = ConnectionFactory.getConnection()){
                PreparedStatement p = con.prepareStatement(sql);
                ResultSet rs = p.executeQuery();
                while(rs.next()){
                    Long id = rs.getLong("id");
                    String nome = rs.getString("nome");
                    Double salario = rs.getDouble("salario");
                    Cargo c = Cargo.valueOf(rs.getString("cargo"));
                    q.add(new Questao1(id, nome, c, salario));
                }
            }
        }catch (SQLException ex){
            throw new RuntimeException(ex);
        }
        return q;
    }
    @Override
    public String findAllJsonFormat(){
        List<Questao1> all = findAll();
        Gson gson = new Gson();
        String json = gson.toJson(all);
        return json;
    }

    @Override
    public Optional<Questao1> findById(Long id) {
        String sql = "select * from questao01 where id = ?";
        Questao1 q = null;
        try{
            try(Connection con = ConnectionFactory.getConnection()){
                PreparedStatement p = con.prepareStatement(sql);
                p.setLong(1, id);
                ResultSet rs = p.executeQuery();
                if(rs.next()){
                    Long i = rs.getLong("id");
                    String nome = rs.getString("nome");
                    Double salario = rs.getDouble("salario");
                    Cargo c = Cargo.valueOf(rs.getString("cargo"));
                    q = new Questao1(i, nome, c, salario);
                }
            }
        }catch (SQLException ex){
            throw new RuntimeException(ex);
        }
        return Optional.ofNullable(q);
    }

    @Override
    public String findByIdJsonFormat(Long id){
        AtomicReference<String> response = new AtomicReference<>("Não foi possivel econtrar nada com o ID especificado.");
        Optional<Questao1> q = findById(id);
        q.ifPresent(a -> {
            Gson g = new Gson();
            response.set(g.toJson(a));
        });
        return response.get();
    }

    public List<Questao1> findByCargo(Cargo c) {
        String sql = "select * from questao01 where cargo = ?";
        List<Questao1> q = new ArrayList<>();
        try{
            try(Connection con = ConnectionFactory.getConnection()){
                PreparedStatement p = con.prepareStatement(sql);
                p.setString(1, c.toString());
                ResultSet rs = p.executeQuery();
                while(rs.next()){
                    Long id = rs.getLong("id");
                    String nome = rs.getString("nome");
                    Double salario = rs.getDouble("salario");
                    Cargo ca = Cargo.valueOf(rs.getString("cargo"));
                    q.add(new Questao1(id, nome, ca, salario));
                }
            }
        }catch (SQLException ex){
            throw new RuntimeException(ex);
        }
        return q;
    }
}
