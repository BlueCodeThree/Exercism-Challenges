class HighScores

    def initialize(scores)
        @scores = scores
    end

    def scores
        return @scores
    end

    def latest
        return @scores[-1]
    end

    def personal_best
        return @scores.max
    end

    def personal_top_three
        sorted = @scores.sort.reverse
        top_three = []
        top_three.push(sorted[0])
        top_three.push(sorted[1]) if sorted[1] != nil
        top_three.push(sorted[2]) if sorted[2] != nil
        return top_three
    end

end
